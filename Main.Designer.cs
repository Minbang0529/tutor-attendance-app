namespace CScritC
{
    partial class Main
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
            this.btna1 = new System.Windows.Forms.Button();
            this.btnb1 = new System.Windows.Forms.Button();
            this.btnc1 = new System.Windows.Forms.Button();
            this.btnd1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btna1
            // 
            this.btna1.Location = new System.Drawing.Point(28, 25);
            this.btna1.Name = "btna1";
            this.btna1.Size = new System.Drawing.Size(120, 107);
            this.btna1.TabIndex = 0;
            this.btna1.Text = "Students";
            this.btna1.UseVisualStyleBackColor = true;
            this.btna1.Click += new System.EventHandler(this.btna1_Click);
            // 
            // btnb1
            // 
            this.btnb1.Location = new System.Drawing.Point(178, 25);
            this.btnb1.Name = "btnb1";
            this.btnb1.Size = new System.Drawing.Size(120, 107);
            this.btnb1.TabIndex = 1;
            this.btnb1.Text = "Classes";
            this.btnb1.UseVisualStyleBackColor = true;
            this.btnb1.Click += new System.EventHandler(this.btnb1_Click);
            // 
            // btnc1
            // 
            this.btnc1.Location = new System.Drawing.Point(28, 157);
            this.btnc1.Name = "btnc1";
            this.btnc1.Size = new System.Drawing.Size(120, 107);
            this.btnc1.TabIndex = 2;
            this.btnc1.Text = "Finance";
            this.btnc1.UseVisualStyleBackColor = true;
            this.btnc1.Click += new System.EventHandler(this.btnc1_Click);
            // 
            // btnd1
            // 
            this.btnd1.Location = new System.Drawing.Point(178, 157);
            this.btnd1.Name = "btnd1";
            this.btnd1.Size = new System.Drawing.Size(120, 107);
            this.btnd1.TabIndex = 3;
            this.btnd1.Text = "Settings";
            this.btnd1.UseVisualStyleBackColor = true;
            this.btnd1.Click += new System.EventHandler(this.btnd1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 293);
            this.Controls.Add(this.btnd1);
            this.Controls.Add(this.btnc1);
            this.Controls.Add(this.btnb1);
            this.Controls.Add(this.btna1);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btna1;
        private System.Windows.Forms.Button btnb1;
        private System.Windows.Forms.Button btnc1;
        private System.Windows.Forms.Button btnd1;
    }
}

