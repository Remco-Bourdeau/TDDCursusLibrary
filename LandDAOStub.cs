using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class LandDAOStub : ILandDAO
    {
        public int OppervlakteAlleLanden()
        {
            return 20;
        }

        public Land Read(string landcode)
        {
            return new Land { Landcode = landcode, Oppervlakte = 5 };
        }
    }
}
