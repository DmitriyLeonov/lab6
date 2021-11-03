using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    partial class Exam : Experiment
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string GetTheme()
        {
            return this.GetSubject();
        }

        public string GetSubject()
        {
            return this.Subject;
        }

        public override DateTime GetDate()
        {
            return examDate;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public override string ToString()
        {
            return "Theme";
        }
    }
}
