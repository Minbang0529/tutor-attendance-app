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
    public partial class A2 : Form
    {
        public A2()
        {
            InitializeComponent();
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void A2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.a2open = false;
            refreshstudent();
            A1 ta1 = new A1();  //does not work for unknown reason.
            ta1.refreshstudent();
            ta1.refresha1(); 
        }
        public static void refreshstudent()
        {
            A1 ta1 = new A1();  //does not refresh the listbox in form A1 for some unknown reason.
            Main.studentviewlist.Clear();   //the datasource itself is updated without problem.
            foreach (Student ppl in Main.studentlist)
            {
                Main.studentviewlist.Add(ppl.ToListView());
            }
            ta1.listBox1.DataSource = null;
            Task.Delay(1).Wait();
            ta1.listBox1.DataSource = Main.studentviewlist;
        }

        private void addOK_Click(object sender, EventArgs e)
        {

            Student tempstudent = new Student();
            try     //acts as a validation. If an input is wrong enough to cause an exeption, then it catches the exeption.
            {   //if inputs do not cause such error, details can be easily edited afterwards
                tempstudent.name = addNameBox.Text;
                tempstudent.age = int.Parse(addAgeBox.Text);
                tempstudent.school = addSchoolBox.Text;
                tempstudent.payweek = Main.payweek;
                Main.studentlist.Add(tempstudent);
                Main.savestudent();
                Main.loadstudent(false);
                refreshstudent();
                A1 ta1 = new A1();
                ta1.refreshstudent();
                ta1.refresha1();
                Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }
    }
}
