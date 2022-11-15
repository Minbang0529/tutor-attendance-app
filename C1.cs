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
    public partial class C1 : Form
    {
        public C1()
        {
            InitializeComponent();
        }

        private void C1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.c1open = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Main.c2open)
            {
                Main.c2open = true;
                C2 c2form = new CScritC.C2();
                c2form.Show(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Main.c3open)
            {
                Main.c3open = true;
                C3 c3form = new CScritC.C3();
                c3form.Show(this);
            }
        }
    }
}
