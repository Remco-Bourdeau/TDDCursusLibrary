using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Jaar
    {
        private readonly int jaar;
        public Jaar(int jaar)
        {
            this.jaar = jaar;
        }
        public bool IsSchrikkeljaar
        {
            get
            {
                if (jaar % 400 == 0) return true;
                if (jaar % 100 == 0) return false;
                return jaar % 4 == 0;
            }
        }
    }
}
