namespace CalendarAppV2
{
    partial class eventsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventsMainContainer = new System.Windows.Forms.Panel();
            this.errorText = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.eventsDescription = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eventsType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.eventsDate = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.eventsLocation = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.eventsName = new System.Windows.Forms.RichTextBox();
            this.eventsButtonsPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.eventsMainContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.eventsButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsMainContainer
            // 
            this.eventsMainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventsMainContainer.Controls.Add(this.errorText);
            this.eventsMainContainer.Controls.Add(this.panel5);
            this.eventsMainContainer.Controls.Add(this.panel4);
            this.eventsMainContainer.Controls.Add(this.header);
            this.eventsMainContainer.Controls.Add(this.panel3);
            this.eventsMainContainer.Controls.Add(this.panel2);
            this.eventsMainContainer.Controls.Add(this.panel1);
            this.eventsMainContainer.Controls.Add(this.eventsButtonsPanel);
            this.eventsMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsMainContainer.Location = new System.Drawing.Point(0, 0);
            this.eventsMainContainer.Name = "eventsMainContainer";
            this.eventsMainContainer.Size = new System.Drawing.Size(457, 376);
            this.eventsMainContainer.TabIndex = 0;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(255, 8);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(197, 13);
            this.errorText.TabIndex = 4;
            this.errorText.Text = "All the required* fields must be filled!";
            this.errorText.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.eventsDescription);
            this.panel5.Location = new System.Drawing.Point(12, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 109);
            this.panel5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Description";
            // 
            // eventsDescription
            // 
            this.eventsDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eventsDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eventsDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventsDescription.DetectUrls = false;
            this.eventsDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventsDescription.Location = new System.Drawing.Point(7, 28);
            this.eventsDescription.Name = "eventsDescription";
            this.eventsDescription.Size = new System.Drawing.Size(423, 78);
            this.eventsDescription.TabIndex = 0;
            this.eventsDescription.Text = "";
            this.eventsDescription.TextChanged += new System.EventHandler(this.eventsDescription_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.eventsType);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(282, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 58);
            this.panel4.TabIndex = 3;
            // 
            // eventsType
            // 
            this.eventsType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventsType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventsType.FormattingEnabled = true;
            this.eventsType.Items.AddRange(new object[] {
            "Personal",
            "Work",
            "Urgent"});
            this.eventsType.Location = new System.Drawing.Point(7, 28);
            this.eventsType.Name = "eventsType";
            this.eventsType.Size = new System.Drawing.Size(121, 21);
            this.eventsType.TabIndex = 2;
            this.eventsType.SelectedIndexChanged += new System.EventHandler(this.eventsType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type*";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(3, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(112, 30);
            this.header.TabIndex = 2;
            this.header.Text = "New Event";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.eventsDate);
            this.panel3.Location = new System.Drawing.Point(279, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 58);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // eventsDate
            // 
            this.eventsDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eventsDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eventsDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventsDate.DetectUrls = false;
            this.eventsDate.Enabled = false;
            this.eventsDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventsDate.Location = new System.Drawing.Point(7, 28);
            this.eventsDate.Multiline = false;
            this.eventsDate.Name = "eventsDate";
            this.eventsDate.Size = new System.Drawing.Size(153, 21);
            this.eventsDate.TabIndex = 0;
            this.eventsDate.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.eventsLocation);
            this.panel2.Location = new System.Drawing.Point(12, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 58);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // eventsLocation
            // 
            this.eventsLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eventsLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eventsLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventsLocation.DetectUrls = false;
            this.eventsLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventsLocation.Location = new System.Drawing.Point(7, 28);
            this.eventsLocation.Multiline = false;
            this.eventsLocation.Name = "eventsLocation";
            this.eventsLocation.Size = new System.Drawing.Size(251, 21);
            this.eventsLocation.TabIndex = 0;
            this.eventsLocation.Text = "";
            this.eventsLocation.TextChanged += new System.EventHandler(this.eventsLocation_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.eventsName);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name*";
            // 
            // eventsName
            // 
            this.eventsName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eventsName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eventsName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventsName.DetectUrls = false;
            this.eventsName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventsName.Location = new System.Drawing.Point(7, 28);
            this.eventsName.Multiline = false;
            this.eventsName.Name = "eventsName";
            this.eventsName.Size = new System.Drawing.Size(248, 21);
            this.eventsName.TabIndex = 0;
            this.eventsName.Text = "";
            this.eventsName.TextChanged += new System.EventHandler(this.eventsName_TextChanged);
            // 
            // eventsButtonsPanel
            // 
            this.eventsButtonsPanel.Controls.Add(this.cancelBtn);
            this.eventsButtonsPanel.Controls.Add(this.saveBtn);
            this.eventsButtonsPanel.Location = new System.Drawing.Point(12, 296);
            this.eventsButtonsPanel.Name = "eventsButtonsPanel";
            this.eventsButtonsPanel.Size = new System.Drawing.Size(433, 63);
            this.eventsButtonsPanel.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(25, 14);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(334, 14);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 33);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // eventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(457, 376);
            this.Controls.Add(this.eventsMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eventsForm";
            this.Text = "eventsForm";
            this.eventsMainContainer.ResumeLayout(false);
            this.eventsMainContainer.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.eventsButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel eventsMainContainer;
        private System.Windows.Forms.Panel eventsButtonsPanel;
        private System.Windows.Forms.RichTextBox eventsName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox eventsLocation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox eventsType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox eventsDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox eventsDescription;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label errorText;
    }
}