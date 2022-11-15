using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CScritC
{
    public partial class D1 : Form
    {
        public D1()
        {
            InitializeComponent();
            Main.loadsettings();
            comboBox1.Text = Main.sorttype;
            if (Main.checkconfirm == "true")
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
        }
        
        private void D1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.d1open = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save
            if (checkBox1.Checked)
                Main.checkconfirm = "true";
            else
                Main.checkconfirm = "false";
            Main.sorttype = comboBox1.Text;
            Main.payweek = int.Parse(textBox1.Text);
            Main.payamount = int.Parse(textBox2.Text);
            Main.savesettings();
            Main.loadsettings();
            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //cancel
            Close();
        }

        private void D1_Shown(object sender, EventArgs e)
        {
            comboBox1.Text = Main.sorttype; //calls to public static variables in Main form
            textBox1.Text = Main.payweek.ToString();
            textBox2.Text = Main.payamount.ToString();
            if (Main.checkconfirm == "true")
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
        }
    }
}
