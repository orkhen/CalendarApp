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
using static System.TimeZoneInfo;

namespace CalendarAppV2
{
    public partial class eventsForm : Form
    {
        private string date;
        private string name;
        private string location;
        private string description;
        private string type;

        public eventsForm(bool flag, DateTime date, string name = "", string location = "", string description = "", string type = "")
        {
            InitializeComponent();
            this.date = date.ToString("dd/MM/yyyy");
            eventsDate.Text = this.date;

            this.name = name;
            this.location = location;
            this.description = description;
            this.type = type;

            checkFlag(flag);
        }


        private void checkFlag(bool flag)
        {
            if (flag)
            {
                header.Text = name;

                eventsName.Enabled = false;
                eventsName.Text = name;

                eventsLocation.Enabled = false;
                eventsLocation.Text = location;

                eventsDescription.Enabled = false;
                eventsDescription.Text = description;

                eventsType.Enabled = false;
                eventsType.Text = type;

                saveBtn.Visible = false;
                cancelBtn.Text = "Close";
                cancelBtn.Location = new System.Drawing.Point(334, 14);

            } else {
                eventsName.Enabled = true;
                eventsLocation.Enabled = true;
                eventsDescription.Enabled = true;
                eventsType.Enabled = true;

                saveBtn.Visible = true;
                cancelBtn.Text = "Cancel";
                cancelBtn.Location = new System.Drawing.Point(25, 14);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            resetData();
            Close();
        }

        private void resetData()
        {
            date = "";
            name = "";
            location = "";
            description = "";
            type = "";
        }

        private void eventsName_TextChanged(object sender, EventArgs e)
        {
            name = eventsName.Text;
        }

        private void eventsLocation_TextChanged(object sender, EventArgs e)
        {
            location = eventsLocation.Text;
        }

        private void eventsDescription_TextChanged(object sender, EventArgs e)
        {
            description = eventsDescription.Text;
        }

        private void eventsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = eventsType.SelectedItem.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (name != null && type != null) {
                saveData();
                //displayMsg();
                resetData();
                Close();
            } else
            {
                displayErr();
            }
        }

        private void saveData()
        {
            string filePath = "..\\..\\..\\data\\events.csv";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                //writer.Write("\n");
                writer.WriteLine($"{{{date}}}, {{{name}}}, {{{location}}}, {{{description}}}, {{{type}}}");
            }
        }
        private async void displayErr()
        {
            errorText.Visible = false;
            await Task.Delay(50);
            errorText.Visible = true;
            await Task.Delay(50);
            errorText.Visible = false;
            await Task.Delay(55);
            errorText.Visible = true;
        }
        private async void displayMsg()
        {
            saveMsgForm msg = new saveMsgForm();
            msg.StartPosition = FormStartPosition.CenterParent;
            msg.ShowDialog();
            await Task.Delay(1000);
            msg.Close();
        }
    }
}
