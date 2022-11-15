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
    public partial class A1 : Form
    {
        public A1()
        {
            InitializeComponent();
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

        private void A1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.a1open = false;
            Main.savestudent();
            Main.loadstudent(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Main.a3open)
            {
                Main.a3open = true;
                A3 a3form = new CScritC.A3();
                a3form.Show(this);
            }
        }

        public static Student selectedstudent = new Student();
        public static int stlistindex;

        public void refreshstudent()
        {
            Main.studentviewlist.Clear();   //clear list
            foreach (Student ppl in Main.studentlist)   //refill list with updated information
            {
                Main.studentviewlist.Add(ppl.ToListView());
            }
            listBox1.DataSource = null; //reset the datasource of the listbox
            Task.Delay(1).Wait();
            listBox1.DataSource = Main.studentviewlist;
        }

        private void A1_Load(object sender, EventArgs e)
        {
            refreshstudent();
        }

        public void selectrefresh() //refreshes what is selected on the listbox.
        {
            if (listBox1.SelectedIndex < 0)
                listBox1.SelectedIndex = 0;
            stlistindex = listBox1.SelectedIndex;
            try     //abort process if an exception is met
            {
                selectedstudent = Main.studentlist.ElementAt<Student>(stlistindex);
            }
            catch
            { }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectrefresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //remove student
            if (Main.checkconfirm == "true")
            {
                if (MessageBox.Show("Confirm Deletion?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)   //show confirmation window
                {
                    Main.studentlist.RemoveAt(listBox1.SelectedIndex);
                    refreshstudent();
                }
            }
            else
            {
              Main.studentlist.RemoveAt(listBox1.SelectedIndex);
              refreshstudent();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            refresha1();    //force a refresh on the listbox in case it is not being updated

        }
        public void refresha1()
        {
            listBox1.DataSource = null; //does not function as expected when executed via an object reference in form A2.
            Task.Delay(1).Wait();
            listBox1.DataSource = Main.studentviewlist;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //swaps sorttype variable, loading student has the sorting function included in it.
            if (Main.sorttype == "Name")
            {
                Main.sorttype = "Age";
                Main.savestudent();
                Main.loadstudent(false);
                refresha1();
            }
            else
            {
                Main.sorttype = "Name";
                Main.savestudent();
                Main.loadstudent(false);
                refresha1();
            }
        }
    }
}
