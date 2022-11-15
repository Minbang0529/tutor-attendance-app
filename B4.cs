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
    public partial class B4 : Form
    {
        public B4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //toggle presence
            if (attendence[listBox1.SelectedIndex] == "Present")
                attendence[listBox1.SelectedIndex] = "Absent";
            else
                attendence[listBox1.SelectedIndex] = "Present";
            if (atdlist[listBox1.SelectedIndex].name.Length < 8)
                viewprop = atdlist[listBox1.SelectedIndex].name + "\t\t" + attendence[listBox1.SelectedIndex];
            else
                viewprop = atdlist[listBox1.SelectedIndex].name + "\t" + attendence[listBox1.SelectedIndex];
            viewlist[listBox1.SelectedIndex] = viewprop;
            listBox1.DataSource = null;
            listBox1.DataSource = viewlist;
        }

        private void B4_Load(object sender, EventArgs e)
        {
            getinfo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public List<Student> atdlist = B1.selectedlesson.memberinfo;
        public string[] attendence = new string[B1.selectedlesson.membernameinfo.Count()];
        List<string> viewlist = new List<string>();
        string viewprop;
        private void getinfo()
        {
            
            int count = 0;
            foreach(string item in attendence)
            {
                attendence[count] = "Present";
                count++;
            }
            
            count = 0;
            foreach(Student ppl in atdlist)
            {
                
                if (ppl.name.Length < 8)
                    viewprop = ppl.name + "\t\t" + attendence[count];
                else
                    viewprop = ppl.name + "\t" + attendence[count];
                viewlist.Add(viewprop);
            }
            listBox1.DataSource = viewlist;
        }


        private void B4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.b4open = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //confirm
            int count = 0;
            foreach (Student ppl in atdlist)
            {
                if (attendence[count] == "Present")
                    ppl.payweek -= 1;
                if (ppl.payweek < 0)
                    ppl.overdueno = ((ppl.payweek*-1)/Main.payweek) + 1;
                Main.studentlist[Main.studentnamelist.IndexOf(ppl.name)] = ppl;
                count++;
            }
            Close();
        }
    }
}
