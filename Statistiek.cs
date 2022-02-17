using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Statistiek
    {
        public static decimal Gemiddelde(decimal[] getallen)
        {
            if (getallen == null)
                throw new ArgumentNullException();
            if (getallen.Length == 0)
                throw new ArgumentException();
            return getallen.Average();
        }
    }
}
