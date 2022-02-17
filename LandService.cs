using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class LandService
    {
        private readonly ILandDAO landDAO;
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
        public decimal FindVerhoudingOppervlakteLandTOVOppervlakteAlleLanden(string landcode)
        {
            var land = landDAO.Read(landcode);
            var oppervlakteAlleLanden = landDAO.OppervlakteAlleLanden();
            return (decimal)land.Oppervlakte / oppervlakteAlleLanden;
        }
    }
}
