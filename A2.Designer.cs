namespace CScritC
{
    partial class A2
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
            this.addNameBox = new System.Windows.Forms.TextBox();
            this.addAgeBox = new System.Windows.Forms.TextBox();
            this.addSchoolBox = new System.Windows.Forms.TextBox();
            this.addCancel = new System.Windows.Forms.Button();
            this.addOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 20F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "School:";
            // 
            // addNameBox
            // 
            this.addNameBox.Location = new System.Drawing.Point(88, 82);
            this.addNameBox.Name = "addNameBox";
            this.addNameBox.Size = new System.Drawing.Size(169, 25);
            this.addNameBox.TabIndex = 4;
            // 
            // addAgeBox
            // 
            this.addAgeBox.Location = new System.Drawing.Point(88, 132);
            this.addAgeBox.Name = "addAgeBox";
            this.addAgeBox.Size = new System.Drawing.Size(169, 25);
            this.addAgeBox.TabIndex = 5;
            // 
            // addSchoolBox
            // 
            this.addSchoolBox.Location = new System.Drawing.Point(88, 183);
            this.addSchoolBox.Name = "addSchoolBox";
            this.addSchoolBox.Size = new System.Drawing.Size(169, 25);
            this.addSchoolBox.TabIndex = 6;
            // 
            // addCancel
            // 
            this.addCancel.Location = new System.Drawing.Point(128, 229);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(68, 43);
            this.addCancel.TabIndex = 7;
            this.addCancel.Text = "Cancel";
            this.addCancel.UseVisualStyleBackColor = true;
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // addOK
            // 
            this.addOK.Location = new System.Drawing.Point(211, 229);
            this.addOK.Name = "addOK";
            this.addOK.Size = new System.Drawing.Size(60, 43);
            this.addOK.TabIndex = 8;
            this.addOK.Text = "OK";
            this.addOK.UseVisualStyleBackColor = true;
            this.addOK.Click += new System.EventHandler(this.addOK_Click);
            // 
            // A2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 288);
            this.Controls.Add(this.addOK);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addSchoolBox);
            this.Controls.Add(this.addAgeBox);
            this.Controls.Add(this.addNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "A2";
            this.Text = "Add Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.A2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addNameBox;
        private System.Windows.Forms.TextBox addAgeBox;
        private System.Windows.Forms.TextBox addSchoolBox;
        private System.Windows.Forms.Button addCancel;
        private System.Windows.Forms.Button addOK;
    }
}