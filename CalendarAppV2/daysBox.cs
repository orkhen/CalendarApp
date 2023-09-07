using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Google.Protobuf;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CalendarAppV2
{
    public partial class daysBox : UserControl
    {
        private string date;
        private DateTime datetime;

        private static eventsForm eventWindow;
        public daysBox(int currDay, int currMonth, int currYear, bool isCurrMonth = true)
        {
            InitializeComponent();
            date = $"{currDay}/{currMonth}/{currYear}";
            dayText.Text = currDay.ToString();

            string[] dateFormats = new string[] { "d/M/yyyy", "d/MM/yyyy", "dd/M/yyyy", "dd/MM/yyyy" };
            DateTime parsedDate;

            // Attempt to parse the date using various formats
            if (DateTime.TryParseExact(date, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                datetime = parsedDate;
            }
            else
            {
                MessageBox.Show("Invalid date format: " + date);
            }

            string currDate = $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";

            BackColor = !isCurrMonth ? Color.FromArgb(212, 212, 212) : Color.White;

            if (date == currDate)
            {
                BackColor = Color.PowderBlue;
                dayText.ForeColor = Color.White;
            }

            updateEventNames();
        }


        private void updateEventNames()
        {
            string filePath = "..\\..\\..\\data\\events.csv";
            string eventsData = File.ReadAllText(filePath);

            string pattern = @"\{([^{}]*)\}";

            string[] lines = eventsData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder updatedData = new StringBuilder();

            foreach ( string line in lines )
            {
                MatchCollection matches = Regex.Matches(line, pattern);
                if (matches.Count >= 5)
                {
                    string date = matches[0].Groups[1].Value;
                    string name = matches[1].Groups[1].Value;

                    if (date == datetime.ToString("dd/MM/yyyy"))
                    {
                        Label text = new Label();
                        text.AutoSize = true;
                        text.Text = name;
                        dayBoxEvents.Controls.Add(text);
                    }
                }
            }
        }



        private void dayInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            eventWindow = new eventsForm(false, datetime);
            eventWindow.StartPosition = FormStartPosition.CenterParent;
            eventWindow.ShowDialog(this);
        }

        private void daysBox_DoubleClick(object sender, EventArgs e)
        {
            eventWindow = new eventsForm(false, datetime);
            eventWindow.StartPosition = FormStartPosition.CenterParent;
            eventWindow.ShowDialog(this);
        }
    }
}
