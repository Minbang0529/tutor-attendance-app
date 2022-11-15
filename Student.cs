using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CScritC
{
    public class Student : IComparable<Student> //can be used in Sort()
    {
        public string name = "";
        public int age = 0;
        public string rawclassinfo = "";
        public List<Lesson> classinfo = new List<Lesson>();
        public List<String> classnameinfo = new List<String>();
        public string school = "";
        public int overdueno = 0;
        public int payweek = 0;
        public string addnote = "";
        public string ToName()
        {
            return name;
        }
        public string ToListView()
        {
            if (name.Length < 8)
                return name + '\t' + '\t' + age.ToString() + '\t' + school;
            else
                return name + '\t' + age.ToString() + '\t' + school;
        }
        public int CompareTo(Student that)  //guide on sorting Student objects
        {
            if (Main.sorttype == "Name")    //sorting method differs on what sort type is currently selected
            {
                return string.Compare(this.name, that.name);
            }
            else
            {
                if (this.age > that.age)
                    return -1;
                else if (this.age < that.age)
                    return 1;
                else
                    return 0;
            }
        }
    }
}
