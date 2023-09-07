using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarAppV2
{
    public partial class eventsBar : UserControl
    {
        private string date;
        private string name;
        private string location;
        private string description;
        private string type;
        private DateTime datetime;

        private static eventsForm eventWindow;

        public eventsBar(DateTime date, string name, string location, string description, string type)
        {
            InitializeComponent();
            this.date = date.ToString("dd/MM/yyyy");
            this.name = name;
            this.location = location;
            this.description = description;
            this.type = type;
            this.datetime = date;

            updateBar(this.date, name, location, description, type);
        }

        private void updateBar(string date, string name, string location, string description, string type)
        {
            nameText.Text = name;
            dateText.Text = date;
            typeText.Text = type;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            deleteEvent();
        }

        private void deleteEvent()
        {
            string filePath = "..\\..\\..\\data\\events.csv";
            string tempFilePath = "..\\..\\..\\data\\temp_events.csv";

            string eventsData = File.ReadAllText(filePath);

            string pattern = @"\{([^{}]*)\}";

            string[] lines = eventsData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder updatedData = new StringBuilder();

            foreach (string line in lines)
            {
                MatchCollection matches = Regex.Matches(line, pattern);
                if (matches.Count >= 5 )
                {
                    string date = matches[0].Groups[1].Value;
                    string name = matches[1].Groups[1].Value;
                    string location = matches[2].Groups[1].Value;
                    string description = matches[3].Groups[1].Value;
                    string type = matches[4].Groups[1].Value;

  //                  Console.WriteLine($"{this.date} {this.name} {this.location} {this.description} {this.type}");
//                    Console.WriteLine($"{date} {name} {location} {description} {type}");

                    if (this.date == date && this.name == name && this.location == location && this.description == description && this.type == type)
                    {
                        continue;
                    }
                }

                updatedData.AppendLine(line);
            }

            File.WriteAllText(tempFilePath, updatedData.ToString());
            File.Replace(tempFilePath, filePath, null);
            File.Delete(tempFilePath);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            ;
        }

        private void nameText_Click(object sender, EventArgs e)
        {
            eventWindow = new eventsForm(true, datetime, name, location, description, type);
            eventWindow.StartPosition = FormStartPosition.CenterParent;
            eventWindow.ShowDialog(this);
        }
    }
}
