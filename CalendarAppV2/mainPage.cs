using CircularProgressBar;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalendarAppV2
{
    public partial class mainPage : Form
    {
        private static int daysToDisplay;
        private static DateTime currentDate;
        private DateTime lastModifiedTime;
        private static HashSet<string> checkedTypes = new HashSet<string>(new[] { "Personal", "Work", "Urgent" });
        private static bool checkedChanged;


        public mainPage()
        {
            InitializeComponent();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            int rows = 5;
            int columns = 7;
            daysToDisplay = rows * columns;
            currentDate = DateTime.Now;

            initializeDropBoxes();  
            manageDates(daysToDisplay, currentDate);
            
        }

        private void initializeDropBoxes()
        {
            DateTimeFormatInfo dateFormatInfo = new DateTimeFormatInfo();
            string[] monthNames = dateFormatInfo.MonthNames;

            for (int month = 0; month < monthNames.Length - 1; month++)
            {
                monthPicker.Items.Add(monthNames[month]);
            }

            for (int year = 1980; year <= 2050; year++)
            {
                yearPicker.Items.Add(year);
            }
        }

        private void handleDropBoxes(string currMonth, int currYear)
        {

            monthPicker.SelectedItem = currMonth;
            yearPicker.SelectedItem = currYear;

        }

        private async void manageDates(int daysToDisplay, DateTime currentDate)
        {
            dates.Controls.Clear();

            dates.Visible = false;

            loadBar loadBar = new loadBar();
            midContainer.Controls.Add(loadBar);

            int currYear = currentDate.Year;
            string currMonth = currentDate.ToString("MMMM");
            headerText.Text = $"{currMonth}, {currYear}";

            updateDays(daysToDisplay, currentDate);
            handleDropBoxes(currMonth, currYear);

            Random random = new Random();
            int transitionTime = random.Next(0, 251);
            await Task.Delay(transitionTime);

            midContainer.Controls.Remove(loadBar);
            dates.Visible = true;

        }

        private void updateDays(int daysToDisplay, DateTime currentDate)
        {
            int daysInCurrentMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            DayOfWeek firstDayOfWeek = firstDayOfMonth.DayOfWeek;
            int firstDayOfWeekInt = (firstDayOfWeek == DayOfWeek.Sunday) ? 7 : (int)firstDayOfWeek;

            DateTime previousMonth = currentDate.AddMonths(-1);
            int startDayInPreviousMonth = DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month) - firstDayOfWeekInt + 1;

            for (int i = 1; i < firstDayOfWeekInt; i++)
            {
                daysBox day = new daysBox(++startDayInPreviousMonth, currentDate.AddMonths(-1).Month, currentDate.Year, false);
                // day.BackColor = Color.FromArgb(212, 212, 212);
                dates.Controls.Add(day);
            }

            for (int i = 1; i <= daysInCurrentMonth; i++)
            {
                daysBox day = new daysBox(i, currentDate.Month, currentDate.Year);
                dates.Controls.Add(day);
            }

            for (int i = 1; i <= daysToDisplay - (daysInCurrentMonth + firstDayOfWeekInt) + 1; i++)
            {
                daysBox day = new daysBox(i, currentDate.AddMonths(1).Month, currentDate.Year, false);
                // day.BackColor = Color.FromArgb(212, 212, 212);
                dates.Controls.Add(day);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            manageDates(daysToDisplay, currentDate);

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            manageDates(daysToDisplay, currentDate);
        }

        private void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDate = new DateTime(currentDate.Year, monthPicker.SelectedIndex + 1, 1);
            manageDates(daysToDisplay, currentDate);
        }

        private void yearPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDate = new DateTime(Convert.ToInt32(yearPicker.SelectedItem), currentDate.Month, 1);
            manageDates(daysToDisplay, currentDate);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            displayEvents();
        }

        private void displayEvents()
        {
            string filePath = "..\\..\\..\\data\\events.csv";

            DateTime currentModifiedTime = File.GetLastWriteTime(filePath);
            if (lastModifiedTime == currentModifiedTime && !checkedChanged)
            {
                return;
            }

            lastModifiedTime = currentModifiedTime;

            string eventsData = File.ReadAllText(filePath);

            string pattern = @"\{([^{}]*)\}";

            eventsPanel.Controls.Clear();
            dates.Controls.Clear();
            manageDates(daysToDisplay, currentDate);

            string[] lines = eventsData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            List<EventData> eventDataList = new List<EventData>();

            foreach (string line in lines)
            {
                MatchCollection matches = Regex.Matches(line, pattern);

                if (matches.Count >= 5)
                {
                    string date = matches[0].Groups[1].Value;
                    string name = matches[1].Groups[1].Value;
                    string location = matches[2].Groups[1].Value;
                    string description = matches[3].Groups[1].Value;
                    string type = matches[4].Groups[1].Value;

                    if (checkedTypes.Contains(type))
                    {
                        DateTime eventDate;
                        if (DateTime.TryParse(date, out eventDate))
                        {
                            eventDataList.Add(new EventData(eventDate, name, location, description, type));
                        }
                    }
                }
            }

            // Sort the event data by date in ascending order
            eventDataList.Sort((a, b) => a.Date.CompareTo(b.Date));

            foreach (var eventData in eventDataList)
            {
                eventsBar eventsBar = new eventsBar(eventData.Date, eventData.Name, eventData.Location, eventData.Description, eventData.Type);
                eventsPanel.Controls.Add(eventsBar);
            }

            checkedChanged = false;
        }

        private class EventData
        {
            public DateTime Date { get; }
            public string Name { get; }
            public string Location { get; }
            public string Description { get; }
            public string Type { get; }

            public EventData(DateTime date, string name, string location, string description, string type)
            {
                Date = date;
                Name = name;
                Location = location;
                Description = description;
                Type = type;
            }
        }


        private void PersonalCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonalCB.Checked)
            {
                checkedTypes.Add("Personal");
            } else {
                checkedTypes.Remove("Personal");
            }

            checkedChanged = true;
        }

        private void WorkCB_CheckedChanged(object sender, EventArgs e)
        {
            if (WorkCB.Checked)
            {
                checkedTypes.Add("Work");
            }
            else
            {
                checkedTypes.Remove("Work");
            }

            checkedChanged = true;
        }

        private void UrgentCB_CheckedChanged(object sender, EventArgs e)
        {
            if (UrgentCB.Checked)
            {
                checkedTypes.Add("Urgent");
            }
            else
            {
                checkedTypes.Remove("Urgent");
            }

            checkedChanged = true;
        }
    }
}
