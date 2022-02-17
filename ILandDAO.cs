using System;


namespace TDDCursusLibrary
{
    public interface ILandDAO
    {
        Land Read(string landcode);
        int OppervlakteAlleLanden();
    }
}
