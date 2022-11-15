using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CScritC
{
    public class Lesson : IComparable<Lesson>   //can be used in sort()
    {
        public string name = "";
        public int starthour = 0;
        public int startmin = 0;
        public int endhour = 0;
        public int endmin = 0;
        public bool repeat = true;
        public string rawweekday = "";
        public string rawmemberinfo = "";
        public List<Student> memberinfo = new List<Student>();
        public List<String> membernameinfo = new List<String>();
        //name|starthour|stmin|endhour|endmin|rp|rweekday|rmemberinfo
        public int CompareTo(Lesson that)   //guideline on how to sort Lesson objects
        {
            if (this.starthour > that.starthour)
                return -1;
            if (this.starthour < that.starthour)
                return 1;
            if (this.starthour == that.starthour)
            {
                if (this.startmin > that.startmin)
                    return -1;
                if (this.startmin < that.startmin)
                    return 1;
                if (this.startmin == that.startmin)
                    return 0;
            }
            return 1;
        }
    }
}
