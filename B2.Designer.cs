namespace CScritC
{
    partial class B2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weekdaycb = new System.Windows.Forms.ComboBox();
            this.sthour = new System.Windows.Forms.ComboBox();
            this.stmin = new System.Windows.Forms.ComboBox();
            this.endmin = new System.Windows.Forms.ComboBox();
            this.endhour = new System.Windows.Forms.ComboBox();
            this.namet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day of Week";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Time";
            // 
            // weekdaycb
            // 
            this.weekdaycb.FormattingEnabled = true;
            this.weekdaycb.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.weekdaycb.Location = new System.Drawing.Point(126, 88);
            this.weekdaycb.Name = "weekdaycb";
            this.weekdaycb.Size = new System.Drawing.Size(90, 23);
            this.weekdaycb.TabIndex = 6;
            // 
            // sthour
            // 
            this.sthour.FormattingEnabled = true;
            this.sthour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.sthour.Location = new System.Drawing.Point(105, 123);
            this.sthour.Name = "sthour";
            this.sthour.Size = new System.Drawing.Size(40, 23);
            this.sthour.TabIndex = 7;
            // 
            // stmin
            // 
            this.stmin.FormattingEnabled = true;
            this.stmin.Location = new System.Drawing.Point(151, 123);
            this.stmin.Name = "stmin";
            this.stmin.Size = new System.Drawing.Size(65, 23);
            this.stmin.TabIndex = 8;
            // 
            // endmin
            // 
            this.endmin.FormattingEnabled = true;
            this.endmin.Location = new System.Drawing.Point(146, 159);
            this.endmin.Name = "endmin";
            this.endmin.Size = new System.Drawing.Size(65, 23);
            this.endmin.TabIndex = 10;
            // 
            // endhour
            // 
            this.endhour.FormattingEnabled = true;
            this.endhour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.endhour.Location = new System.Drawing.Point(100, 159);
            this.endhour.Name = "endhour";
            this.endhour.Size = new System.Drawing.Size(40, 23);
            this.endhour.TabIndex = 9;
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(76, 55);
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(100, 25);
            this.namet.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 48);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // B2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.namet);
            this.Controls.Add(this.endmin);
            this.Controls.Add(this.endhour);
            this.Controls.Add(this.stmin);
            this.Controls.Add(this.sthour);
            this.Controls.Add(this.weekdaycb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "B2";
            this.Text = "Add Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.B2_FormClosing);
            this.Load += new System.EventHandler(this.B2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox weekdaycb;
        private System.Windows.Forms.ComboBox sthour;
        private System.Windows.Forms.ComboBox stmin;
        private System.Windows.Forms.ComboBox endmin;
        private System.Windows.Forms.ComboBox endhour;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}