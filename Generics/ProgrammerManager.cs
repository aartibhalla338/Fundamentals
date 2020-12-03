using System;
using System.Collections.Generic;
using System.Text;
public class ProgrammerManager
{
    public void LoadProgrammers()
    {
        Programmer p1 = new Programmer();
        Programmer p2 = new Programmer("Mattia","C#",1);
        p1.Name = "Riccardo";
        p1.FavouriteLanguage = "C#";
    }
}

