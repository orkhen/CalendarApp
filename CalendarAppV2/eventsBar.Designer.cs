namespace CalendarAppV2
{
    partial class eventsBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eventControlPanel = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.eventNamePanel = new System.Windows.Forms.Panel();
            this.nameText = new System.Windows.Forms.Label();
            this.eventTypePanel = new System.Windows.Forms.Panel();
            this.typeText = new System.Windows.Forms.Label();
            this.eventDatePanel = new System.Windows.Forms.Panel();
            this.dateText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.eventControlPanel.SuspendLayout();
            this.eventNamePanel.SuspendLayout();
            this.eventTypePanel.SuspendLayout();
            this.eventDatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.eventControlPanel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventNamePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventTypePanel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventDatePanel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // eventControlPanel
            // 
            this.eventControlPanel.Controls.Add(this.editBtn);
            this.eventControlPanel.Controls.Add(this.deleteBtn);
            this.eventControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventControlPanel.Location = new System.Drawing.Point(297, 3);
            this.eventControlPanel.Name = "eventControlPanel";
            this.eventControlPanel.Size = new System.Drawing.Size(120, 34);
            this.eventControlPanel.TabIndex = 1;
            // 
            // editBtn
            // 
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.editBtn.Location = new System.Drawing.Point(3, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(78, 28);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.deleteBtn.Location = new System.Drawing.Point(87, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(30, 30);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = " X ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // eventNamePanel
            // 
            this.eventNamePanel.Controls.Add(this.nameText);
            this.eventNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventNamePanel.Location = new System.Drawing.Point(3, 3);
            this.eventNamePanel.Name = "eventNamePanel";
            this.eventNamePanel.Size = new System.Drawing.Size(141, 34);
            this.eventNamePanel.TabIndex = 0;
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameText.Location = new System.Drawing.Point(3, 8);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(44, 17);
            this.nameText.TabIndex = 0;
            this.nameText.Text = "Name";
            this.nameText.Click += new System.EventHandler(this.nameText_Click);
            // 
            // eventTypePanel
            // 
            this.eventTypePanel.Controls.Add(this.typeText);
            this.eventTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventTypePanel.Location = new System.Drawing.Point(234, 3);
            this.eventTypePanel.Name = "eventTypePanel";
            this.eventTypePanel.Size = new System.Drawing.Size(57, 34);
            this.eventTypePanel.TabIndex = 1;
            // 
            // typeText
            // 
            this.typeText.AutoSize = true;
            this.typeText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeText.Location = new System.Drawing.Point(3, 8);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(35, 17);
            this.typeText.TabIndex = 3;
            this.typeText.Text = "Type";
            // 
            // eventDatePanel
            // 
            this.eventDatePanel.Controls.Add(this.dateText);
            this.eventDatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventDatePanel.Location = new System.Drawing.Point(150, 3);
            this.eventDatePanel.Name = "eventDatePanel";
            this.eventDatePanel.Size = new System.Drawing.Size(78, 34);
            this.eventDatePanel.TabIndex = 1;
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateText.Location = new System.Drawing.Point(3, 8);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(35, 17);
            this.dateText.TabIndex = 1;
            this.dateText.Text = "Date";
            // 
            // eventsBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "eventsBar";
            this.Size = new System.Drawing.Size(420, 40);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.eventControlPanel.ResumeLayout(false);
            this.eventNamePanel.ResumeLayout(false);
            this.eventNamePanel.PerformLayout();
            this.eventTypePanel.ResumeLayout(false);
            this.eventTypePanel.PerformLayout();
            this.eventDatePanel.ResumeLayout(false);
            this.eventDatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel eventControlPanel;
        private System.Windows.Forms.Panel eventTypePanel;
        private System.Windows.Forms.Panel eventDatePanel;
        private System.Windows.Forms.Panel eventNamePanel;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label typeText;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}
