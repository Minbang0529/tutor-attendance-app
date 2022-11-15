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
    public partial class A3 : Form
    {
        public A3()
        {
            InitializeComponent();
            pulldata(A1.selectedstudent);
        }
        private void pulldata(Student student1)
        {
            nametb.Text = student1.name;
            agetb.Text = student1.age.ToString();
            schooltb.Text = student1.school;
            addnotertb.Text = student1.addnote;
            label7.Text = student1.rawclassinfo;
            label8.Text = student1.overdueno.ToString();
        }
        private void A3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.a3open = false;
            Main.savestudent();
            Main.loadstudent(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cancel
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save
            A1 ta1 = new A1();
            A1.selectedstudent.name = nametb.Text;
            A1.selectedstudent.age = int.Parse(agetb.Text);
            A1.selectedstudent.school = schooltb.Text;
            A1.selectedstudent.addnote = addnotertb.Text;
            Main.studentlist[A1.stlistindex] = A1.selectedstudent;
            ta1.refreshstudent();
            Close();
        }
    }
}
