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
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void B2_Load(object sender, EventArgs e)
        {

        }

        private void B2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.b2open = false;
            B1 tb1 = new CScritC.B1();
            tb1.refreshtt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cancel
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ok
            Lesson lesson1 = new Lesson();
            lesson1.name = namet.Text;
            lesson1.rawweekday = weekdaycb.Text;
            lesson1.starthour = int.Parse(sthour.Text);
            lesson1.startmin = int.Parse(stmin.Text);
            lesson1.endhour = int.Parse(endhour.Text);
            lesson1.endmin = int.Parse(endmin.Text);
            Main.lessonlist.Add(lesson1);
            Main.savelesson();
            Main.loadlesson(false);
            Close();
        }
    }
}
