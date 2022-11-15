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
    public partial class B1 : Form
    {
        public static DataTable dt = new DataTable();
        bool initialised;
        public B1()
        {
            InitializeComponent();
            
        }

        private void B1_Load(object sender, EventArgs e)
        {
            if (!initialised)
            {
                dt.Columns.Clear();
                dt.Clear();
                dt.Columns.Add("Monday", System.Type.GetType("System.String"));
                dt.Columns.Add("Tuesday", System.Type.GetType("System.String"));
                dt.Columns.Add("Wednesday", System.Type.GetType("System.String"));
                dt.Columns.Add("Thursday", System.Type.GetType("System.String"));
                dt.Columns.Add("Friday", System.Type.GetType("System.String"));
                dt.Columns.Add("Saturday", System.Type.GetType("System.String"));
                dt.Columns.Add("Sunday", System.Type.GetType("System.String"));
                initialised = true;
            }
            dataGridView1.DataSource = dt;
            refreshtt();
        }

        public void refreshtt()
        {
            dt.Clear();
            List<String> monlist = new List<String>();
            List<String> tuelist = new List<String>();
            List<String> wedlist = new List<String>();
            List<String> thulist = new List<String>();
            List<String> frilist = new List<String>();
            List<String> satlist = new List<String>();
            List<String> sunlist = new List<String>();
            foreach (Lesson lsn in Main.lessonlist) //divide the lessons by their respective weekdays
            {
                string viewprop = "";
                if(lsn.startmin < 10)
                    viewprop = lsn.starthour.ToString() + ":0" + lsn.startmin.ToString() + " " + lsn.name;
                else
                    viewprop = lsn.starthour.ToString() + ":" + lsn.startmin.ToString() + " " + lsn.name;
                Main.lessonviewlist.Add(viewprop);
                if (lsn.rawweekday.ToLower() == "monday")
                    monlist.Add(viewprop);
                else if (lsn.rawweekday.ToLower() == "tuesday")
                    tuelist.Add(viewprop);
                else if (lsn.rawweekday.ToLower() == "wednesday")
                    wedlist.Add(viewprop);
                else if (lsn.rawweekday.ToLower() == "thursday")
                    thulist.Add(viewprop);
                else if (lsn.rawweekday.ToLower() == "friday")
                    frilist.Add(viewprop);
                else if (lsn.rawweekday.ToLower() == "saturday")
                    satlist.Add(viewprop);
                else if (lsn.rawweekday.ToLower() == "sunday")
                    sunlist.Add(viewprop);
            }
            monlist.Sort();
            tuelist.Sort();
            wedlist.Sort();
            thulist.Sort();
            frilist.Sort();
            satlist.Sort();
            sunlist.Sort();
            while (monlist.Count != 0 || tuelist.Count != 0 || wedlist.Count != 0 || thulist.Count != 0 || frilist.Count != 0 || satlist.Count != 0 || sunlist.Count != 0 )
            {
                DataRow row = dt.NewRow();
                if (monlist.Count != 0)
                {
                    row["Monday"] = monlist[0];
                    monlist.RemoveAt(0);
                }

                if (tuelist.Count != 0)
                {
                    row["Tuesday"] = tuelist[0];
                    tuelist.RemoveAt(0);
                }

                if (wedlist.Count != 0)
                {
                    row["Wednesday"] = wedlist[0];
                    wedlist.RemoveAt(0);
                }

                if (thulist.Count != 0)
                {
                    row["Thursday"] = thulist[0];
                    thulist.RemoveAt(0);
                }

                if (frilist.Count != 0)
                {
                    row["Friday"] = frilist[0];
                    frilist.RemoveAt(0);
                }

                if (satlist.Count != 0)
                {
                    row["Saturday"] = satlist[0];
                    satlist.RemoveAt(0);
                }
                if (sunlist.Count != 0)
                {
                    row["Sunday"] = sunlist[0];
                    sunlist.RemoveAt(0);
                }
                dt.Rows.Add(row);
            }
        }

        private void B1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.b1open = false;
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!Main.b2open)
            {
                Main.b2open = true;
                B2 b2form = new CScritC.B2();
                b2form.Show(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!Main.b3open)
            {
                if (selectedlesson != null)
                {
                    Main.b3open = true;
                    B3 b3form = new CScritC.B3();
                    b3form.Show(this);
                }
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
        }
        public static Lesson selectedlesson;
        public static int selectedlessonindex = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.CurrentCell.RowIndex.ToString() + dataGridView1.CurrentCell.ColumnIndex.ToString());//row and column in int, currentcell.
            //MessageBox.Show(dt.Rows[0][0].ToString());//get value from (0, 0) of dt.
            //MessageBox.Show(Main.lessonviewlist.IndexOf(dt.Rows[0][1].ToString()).ToString());//get index of the selected item in lessonviewlist
            try
            {
                selectedlesson = Main.lessonlist[Main.lessonviewlist.IndexOf(dt.Rows[dataGridView1.CurrentCell.RowIndex][dataGridView1.CurrentCell.ColumnIndex].ToString())];
                selectedlessonindex = Main.lessonviewlist.IndexOf(dt.Rows[dataGridView1.CurrentCell.RowIndex][dataGridView1.CurrentCell.ColumnIndex].ToString());
            }
            catch
            {

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //remove
            if (Main.checkconfirm == "true")
            {
                if (MessageBox.Show("Confirm Deletion?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Main.lessonlist.Remove(selectedlesson);
                    Main.savelesson();
                    Main.loadlesson(false);
                    refreshtt();
                }
            }
            else
            {
                Main.lessonlist.Remove(selectedlesson);
                Main.savelesson();
                Main.loadlesson(false);
                refreshtt();
            }
        }
    }
}
