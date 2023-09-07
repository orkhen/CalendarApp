namespace CalendarAppV2
{
    partial class daysBox
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
            this.dayText = new System.Windows.Forms.Label();
            this.dayBoxEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dayText
            // 
            this.dayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dayText.AutoSize = true;
            this.dayText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayText.Location = new System.Drawing.Point(4, 9);
            this.dayText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayText.Name = "dayText";
            this.dayText.Size = new System.Drawing.Size(44, 28);
            this.dayText.TabIndex = 0;
            this.dayText.Text = "day";
            this.dayText.DoubleClick += new System.EventHandler(this.daysBox_DoubleClick);
            // 
            // dayBoxEvents
            // 
            this.dayBoxEvents.AutoScroll = true;
            this.dayBoxEvents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.dayBoxEvents.Location = new System.Drawing.Point(0, 51);
            this.dayBoxEvents.Name = "dayBoxEvents";
            this.dayBoxEvents.Size = new System.Drawing.Size(153, 78);
            this.dayBoxEvents.TabIndex = 1;
            this.dayBoxEvents.DoubleClick += new System.EventHandler(this.daysBox_DoubleClick);
            // 
            // daysBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dayText);
            this.Controls.Add(this.dayBoxEvents);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(153, 135);
            this.MinimumSize = new System.Drawing.Size(153, 123);
            this.Name = "daysBox";
            this.Size = new System.Drawing.Size(153, 129);
            this.DoubleClick += new System.EventHandler(this.daysBox_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dayText;
        private System.Windows.Forms.FlowLayoutPanel dayBoxEvents;
    }
}
