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
    public partial class C3 : Form
    {
        public C3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add("Jan: " + Main.recording[0, 0]);
            listBox2.Items.Add("Feb: " + Main.recording[0, 1]);
            listBox2.Items.Add("Mar: " + Main.recording[0, 2]);
            listBox2.Items.Add("Apr: " + Main.recording[0, 3]);
            listBox2.Items.Add("May: " + Main.recording[0, 4]);
            listBox2.Items.Add("Jun: " + Main.recording[0, 5]);
            listBox2.Items.Add("Jul: " + Main.recording[0, 6]);
            listBox2.Items.Add("Aug: " + Main.recording[0, 7]);
            listBox2.Items.Add("Sep: " + Main.recording[0, 8]);
            listBox2.Items.Add("Oct: " + Main.recording[0, 9]);
            listBox2.Items.Add("Nov: " + Main.recording[0, 10]);
            listBox2.Items.Add("Dec: " + Main.recording[0, 11]);
            sum = 0;
            for(int i=0; i<12; i++)
            {
                sum += Main.recording[0, i];
            }
            listBox2.Items.Add("");
            listBox2.Items.Add("Sum: " + sum);
        }
        private int sum;
        private void C3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.c3open = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show monthly/yearly income statistics
            listBox2.Items.Clear();
            listBox2.Items.Add("Jan: " + Main.recording[listBox1.SelectedIndex, 0]);
            listBox2.Items.Add("Feb: " + Main.recording[listBox1.SelectedIndex, 1]);
            listBox2.Items.Add("Mar: " + Main.recording[listBox1.SelectedIndex, 2]);
            listBox2.Items.Add("Apr: " + Main.recording[listBox1.SelectedIndex, 3]);
            listBox2.Items.Add("May: " + Main.recording[listBox1.SelectedIndex, 4]);
            listBox2.Items.Add("Jun: " + Main.recording[listBox1.SelectedIndex, 5]);
            listBox2.Items.Add("Jul: " + Main.recording[listBox1.SelectedIndex, 6]);
            listBox2.Items.Add("Aug: " + Main.recording[listBox1.SelectedIndex, 7]);
            listBox2.Items.Add("Sep: " + Main.recording[listBox1.SelectedIndex, 8]);
            listBox2.Items.Add("Oct: " + Main.recording[listBox1.SelectedIndex, 9]);
            listBox2.Items.Add("Nov: " + Main.recording[listBox1.SelectedIndex, 10]);
            listBox2.Items.Add("Dec: " + Main.recording[listBox1.SelectedIndex, 11]);
            sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += Main.recording[listBox1.SelectedIndex, i];
            }
            listBox2.Items.Add("");
            listBox2.Items.Add("Sum: " + sum);
        }

        private void C3_Load(object sender, EventArgs e)
        {

        }
    }
}
