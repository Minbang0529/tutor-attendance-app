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
    public partial class B3 : Form
    {
        public B3()
        {
            InitializeComponent();
            getinfo(B1.selectedlesson);
        }

        private void B3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.b3open = false;
            B1 tb1 = new CScritC.B1();
            tb1.refreshtt();
        }
        public void refreshb3()
        {
            getinfo(B1.selectedlesson);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Main.b4open)
            {
                Main.b4open = true;
                B4 b4form = new CScritC.B4();
                b4form.Show(this);
            }
        }

        private void getinfo(Lesson lsn)
        {
            label1.Text = lsn.name;
            listBox1.DataSource = lsn.membernameinfo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //select student
            if (!Main.b5open)
            {
                Main.b5open = true;
                B5 b5form = new CScritC.B5();
                b5form.Show(this);
            }
            B5 tb5 = new B5();
            tb5.lbb5.DataSource = Main.studentnamelist;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //student info
            if (!Main.a3open)
            {
                Main.a3open = true;
                A3 a3form = new CScritC.A3();
                a3form.Show(this);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
                A1.selectedstudent = Main.studentlist[Main.studentnamelist.IndexOf(listBox1.SelectedItem.ToString())];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //remove student
            if (Main.checkconfirm == "true")
            {
                if (MessageBox.Show("Confirm Deletion?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)   //confirmation
                {
                    string[] temparray = B1.selectedlesson.rawmemberinfo.Split(',');    //converts the rawmemberinfo into an array
                    string tempstring = "";
                    foreach (string tempstr in temparray)
                    {
                        if (tempstr != listBox1.SelectedItem.ToString())    //changes the rawmemberinfo accordingly to removal of a student from a class
                        {
                            tempstring += tempstr;
                            tempstring += ",";
                        }
                        if (tempstring != "")
                            tempstring = tempstring.Remove(tempstring.Length - 1, 1);
                        B1.selectedlesson.rawmemberinfo = tempstring;
                    }
                    temparray = Main.studentlist[Main.studentnamelist.IndexOf(listBox1.SelectedItem.ToString())].rawclassinfo.Split(',');
                    foreach (string tempstr in temparray)
                    {
                        if (tempstr != B1.selectedlesson.name)
                        {
                            tempstring += tempstr;
                            tempstring += ",";
                        }
                        if (tempstring != "")
                            tempstring = tempstring.Remove(tempstring.Length - 1, 1);
                        Main.studentlist[Main.studentnamelist.IndexOf(listBox1.SelectedItem.ToString())].rawclassinfo = tempstring;
                        Main.savestudent();
                        Main.loadstudent(false);
                        Main.savelesson();
                        Main.loadlesson(false);
                    }
                }
            }
            else    //same thing without confirmation
            {
                string[] temparray = B1.selectedlesson.rawmemberinfo.Split(',');
                string tempstring = "";
                foreach(string tempstr in temparray)
                {
                    if(tempstr != listBox1.SelectedItem.ToString())
                    {
                        tempstring += tempstr;
                        tempstring += ",";
                    }
                    if(tempstring != "")
                        tempstring = tempstring.Remove(tempstring.Length - 1, 1);
                    B1.selectedlesson.rawmemberinfo = tempstring;
                }
                temparray = Main.studentlist[Main.studentnamelist.IndexOf(listBox1.SelectedItem.ToString())].rawclassinfo.Split(',');
                foreach (string tempstr in temparray)
                {
                    if (tempstr != B1.selectedlesson.name)
                    {
                        tempstring += tempstr;
                        tempstring += ",";
                    }
                    if (tempstring != "")
                        tempstring = tempstring.Remove(tempstring.Length - 1, 1);
                    Main.studentlist[Main.studentnamelist.IndexOf(listBox1.SelectedItem.ToString())].rawclassinfo = tempstring;
                    Main.savestudent();
                    Main.loadstudent(false);
                    Main.savelesson();
                    Main.loadlesson(false);
                }
            }            
        }
    }
}
