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
    public partial class B5 : Form
    {
        public B5()
        {
            InitializeComponent();
            lbb5.DataSource = Main.studentnamelist;
        }
        public void B5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.b5open = false;
            B1 tb1 = new CScritC.B1();
            tb1.refreshtt();
            B3 tb3 = new B3();
            tb3.refreshb3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Main.a2open)
            {
                Main.a2open = true;
                A2 a2form = new CScritC.A2();
                a2form.Show(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Main.a3open)
            {
                Main.a3open = true;
                A3 a3form = new CScritC.A3();
                a3form.Show(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //select student + add in lesson
            if (!B1.selectedlesson.memberinfo.Contains(Main.studentlist[lbb5.SelectedIndex])) //find selected student object from main's lists
            {
                if (B1.selectedlesson.rawmemberinfo != "")
                    B1.selectedlesson.rawmemberinfo += ",";
                B1.selectedlesson.rawmemberinfo += lbb5.SelectedItem;
                Main.lessonlist[B1.selectedlessonindex] = B1.selectedlesson;


                //classinfo here for student
                if (A1.selectedstudent.rawclassinfo != "")
                    A1.selectedstudent.rawclassinfo += ",";
                A1.selectedstudent.rawclassinfo += B1.selectedlesson.name;
                Main.studentlist[Main.studentnamelist.IndexOf(A1.selectedstudent.name)] = A1.selectedstudent;
                Main.savestudent();
                Main.loadstudent(false);


                Main.savelesson();
                Main.loadlesson(false);
            }
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            A1.selectedstudent = Main.studentlist[Main.studentnamelist.IndexOf(lbb5.SelectedItem.ToString())];
        }
        public void refreshb5()
        {
            lbb5.DataSource = null;
            Task.Delay(1).Wait();
            lbb5.DataSource = Main.studentnamelist;
        }
    }
}
