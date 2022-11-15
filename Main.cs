using System;
using System.IO;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public static bool a1open = false;
        public static bool a2open = false;
        public static bool a3open = false;
        public static bool b1open = false;
        public static bool b2open = false;
        public static bool b3open = false;
        public static bool b4open = false;
        public static bool b5open = false;
        public static bool c1open = false;
        public static bool c2open = false;
        public static bool c3open = false;
        public static bool d1open = false;
        public static string checkconfirm;
        public static string sorttype = "";
        public static int payweek;
        public static int payamount;
        public static int[,] recording = new int[4, 12];

        public static List<Student> studentlist = new List<Student>();

        public static List<String> studentviewlist = new List<String>();

        public static List<String> studentnamelist = new List<String>();

        public static List<Lesson> lessonlist = new List<Lesson>();

        public static List<String> lessonviewlist = new List<String>();

        public static List<String> lessonnamelist = new List<String>();

        public static void savestudent()
        {
            using (StreamWriter writer = new StreamWriter("studentinfolist.txt"))
            {
                foreach(Student ppl in studentlist)
                {
                    writer.WriteLine(ppl.name.ToString() + "§" + ppl.age.ToString() + "§" + ppl.rawclassinfo.ToString() + 
                        "§" + ppl.school.ToString() + "§" + ppl.overdueno.ToString() + "§" + ppl.payweek.ToString() + "§" + ppl.addnote.ToString());
                }
            }
        }
        public static void savemoney()
        {
            using (StreamWriter writer = new StreamWriter("money.txt"))
            {
                for(int i=0; i<4; i++)
                {
                    writer.WriteLine(recording[i, 0].ToString() + "§" + recording[i, 1].ToString() + "§" + recording[i, 2].ToString() + "§" + recording[i, 3].ToString() + "§" + recording[i, 4].ToString() + "§" + recording[i, 5].ToString() + "§" + recording[i, 6].ToString() + "§" + recording[i, 7].ToString() + "§" + recording[i, 8].ToString() + "§" + recording[i, 9].ToString() + "§" + recording[i, 10].ToString() + "§" + recording[i, 11].ToString());
                }
            }
        }

        public static void savesettings()
        {
            using (StreamWriter writer = new StreamWriter("settings.txt"))
            {
                //sort|confirm|week|amount
                writer.WriteLine(sorttype + "," + checkconfirm + "," + payweek.ToString() + "," + payamount.ToString());
            }
        }

        public static void savelesson()
        {
            using (StreamWriter writer = new StreamWriter("lessoninfolist.txt"))
            {
                //name|starthour|stmin|endhour|endmin|rp|weekday|memberinfo
                foreach(Lesson period in lessonlist)
                {
                    writer.WriteLine(period.name + "§" + period.starthour.ToString() + "§" + period.startmin.ToString() + "§" + period.endhour.ToString()
                        + "§" + period.endmin.ToString() + "§" + period.repeat.ToString() + "§" + period.rawweekday + "§" + period.rawmemberinfo);
                }
            }
        }

        public static void loadmoney()
        {
            using (StreamReader reader = new StreamReader("money.txt"))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] intarray = line.Split('§');
                    for (int i=0; i<12; i++)
                    {
                        recording[count, i] = int.Parse(intarray[i]);
                    }
                    count++;
                }
            }
        }

        public static void loadsettings()
        {
            using (StreamReader reader = new StreamReader("settings.txt"))
            {
                //sort|confirm|week|amount
                string temp = reader.ReadLine();
                string[] tsetting = temp.Split(',');
                sorttype = tsetting[0];
                checkconfirm = tsetting[1];
                payweek = int.Parse(tsetting[2]);
                payamount = int.Parse(tsetting[3]);
            }
        }

        public static void loadstudent(bool loading)
        {
            using (StreamReader reader = new StreamReader("studentinfolist.txt"))
            {
                studentlist.Clear();
                studentnamelist.Clear();
                studentviewlist.Clear();
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Student tempstudent = new Student();
                    string[] props = line.Split('§');   //name age rawclassinfo school overdueno payweek addnote
                    if (props.Length != 1)
                    {
                        tempstudent.name = props[0];
                        tempstudent.age = int.Parse(props[1]);
                        tempstudent.rawclassinfo = props[2];
                        tempstudent.school = props[3];
                        tempstudent.overdueno = (int.Parse(props[5]) / payweek-1)*-1;
                        tempstudent.payweek = int.Parse(props[5]);
                        tempstudent.addnote = props[6];
                    }
                    studentlist.Add(tempstudent);
                    
                }
                
            }
            //sort
            studentlist.Sort();
            studentnamelist.Clear();
            studentviewlist.Clear();
            foreach (Student ppl in studentlist)
            {
                studentnamelist.Add(ppl.name);
                studentviewlist.Add(ppl.ToListView());
            }
            if (loading)
                loadlesson(false);  //only do this at initialization since loading memberinfos and classinfos require the object names to be loaded beforehand.
            using (StreamReader reader = new StreamReader("studentinfolist.txt"))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null && count < studentlist.Count)
                {
                    Student tempstudent = studentlist[count];
                    string[] props = line.Split('§');   //name age rawclassinfo school overdueno payweek addnote
                    if (props.Length != 1)
                    {
                        string[] temparray = tempstudent.rawclassinfo.Split(',');
                        if (temparray.Length != 0 && temparray[0] != "")
                        {
                            foreach (String lsn in temparray)
                            {
                                tempstudent.classinfo.Add(lessonlist[lessonnamelist.IndexOf(lsn)]);
                                tempstudent.classnameinfo.Add(lsn);
                            }
                        }
                    }
                    studentlist[count] = tempstudent;
                    count++;
                }
            }
            

        }

        public static void loadlesson(bool loading)
        {
            using (StreamReader reader = new StreamReader("lessoninfolist.txt"))
            {
                lessonlist.Clear();
                lessonnamelist.Clear();
                lessonviewlist.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Lesson templesson = new Lesson();
                    string[] props = line.Split('§');   //name age rawclassinfo school overdueno payweek addnote
                    if (props.Length != 1)
                    {
                        templesson.name = props[0];
                        templesson.starthour = int.Parse(props[1]);
                        templesson.startmin = int.Parse(props[2]);
                        templesson.endhour = int.Parse(props[3]);
                        templesson.endmin = int.Parse(props[4]);
                        templesson.repeat = bool.Parse(props[5]);
                        templesson.rawweekday = props[6];
                        templesson.rawmemberinfo = props[7];
                        
                    }
                    lessonlist.Add(templesson);
                    lessonnamelist.Add(templesson.name);
                }
            }
            if(loading)
                loadstudent(false); //used for initialization
            using (StreamReader reader = new StreamReader("lessoninfolist.txt"))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null && count < lessonlist.Count)
                {
                    Lesson templesson = lessonlist[count];
                    string[] props = line.Split('§');   //name age rawclassinfo school overdueno payweek addnote
                    if (props.Length != 1)
                    {
                        string[] temparray = templesson.rawmemberinfo.Split(',');
                        if (temparray.Length != 0 && temparray[0] != "")
                        {
                            foreach (String member in temparray)
                            {
                                templesson.memberinfo.Add(studentlist[studentnamelist.IndexOf(member)]);
                                templesson.membernameinfo.Add(member);
                            }

                        }
                        lessonlist[count] = templesson;
                        count++;
                    }
                }
            }
        }
        private void btna1_Click(object sender, EventArgs e)
        {
                if (!a1open)
            {
                A1 studentform = new A1();
                studentform.Show();
                a1open = true;
            }
        }

        private void btnb1_Click(object sender, EventArgs e)
        {
            if (!b1open)
            {
                B1 classform = new B1();
                classform.Show();
                b1open = true;
            }
        }

        private void btnc1_Click(object sender, EventArgs e)
        {
            if (!c1open)
            {
                C1 financeform = new C1();
                financeform.Show();
                c1open = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadsettings();
            loadmoney();
            loadstudent(true);
        }

        private void btnd1_Click(object sender, EventArgs e)
        {
            if (!d1open)
            {
                D1 settingsform = new D1();
                settingsform.Show();
                d1open = true;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            savemoney();
            savesettings();
            savestudent();
            savelesson();
            
        }
    }
}
