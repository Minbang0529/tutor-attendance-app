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
    public partial class C2 : Form
    {
        public C2()
        {
            InitializeComponent();
        }

        private void C2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.c2open = false;
        }
        List<Student> overdue = new List<Student>();
        List<Student> confirmed = new List<Student>();
        List<string> viewlist = new List<string>();
        private void C2_Load(object sender, EventArgs e)
        {
            refreshc2();
        }
        private void refreshc2()
        {
            overdue.Clear();
            foreach (Student ppl in Main.studentlist)
            {
                if (ppl.payweek < Main.payweek)   //display people who has an upcoming payment soon-ish
                    overdue.Add(ppl);
            }
            foreach (Student ppl in overdue)
            {
                if (ppl.name.Length < 8)
                    viewlist.Add(ppl.name + "\t\t" + ppl.payweek.ToString());
                else
                    viewlist.Add(ppl.name + "\t" + ppl.payweek.ToString());

            }
            listBox1.DataSource = null;
            listBox1.DataSource = viewlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //confirm payment
            overdue[listBox1.SelectedIndex].payweek += Main.payweek;
            if (overdue[listBox1.SelectedIndex].name.Length < 8)
                viewlist[listBox1.SelectedIndex] = overdue[listBox1.SelectedIndex].name + "\t\t" + overdue[listBox1.SelectedIndex].payweek.ToString();
            else
                viewlist[listBox1.SelectedIndex] = overdue[listBox1.SelectedIndex].name + "\t" + overdue[listBox1.SelectedIndex].payweek.ToString();
            confirmed.Add(overdue[listBox1.SelectedIndex]);
            listBox1.DataSource = null;
            listBox1.DataSource = viewlist;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //save
            foreach (Student ppl in confirmed)  //record money earned
            {
                if (ppl.overdueno > 0)
                    ppl.overdueno -= 1;
                Main.studentlist[Main.studentnamelist.IndexOf(ppl.name)] = ppl;
            }
            Main.recording[DateTime.Today.Year - 2017, DateTime.Today.Month - 1] += Main.payamount * confirmed.Count();
            Main.studentlist[Main.studentnamelist.IndexOf(overdue[listBox1.SelectedIndex].name)] = overdue[listBox1.SelectedIndex];
            Main.savestudent();
            Main.loadstudent(false);
            Main.savemoney();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cancel
            foreach (Student ppl in confirmed)
            {
                ppl.payweek -= Main.payweek;
            }
            Close();
        }
    }
}
