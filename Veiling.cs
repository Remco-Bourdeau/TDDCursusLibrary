using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Veiling
    {
        public decimal HoogsteBod { get; set; }

        public void DoeBod(decimal bod)
        {
            if (bod > HoogsteBod)
                HoogsteBod = bod;
        }
    }
}
