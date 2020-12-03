using System;
using System.Collections.Generic;
using System.Text;
public class Programmer
{
    public string Name {get; set;}
    public string FavouriteLanguage { get; set;}
    public int Id {get; set;}
    
    public Programmer (string name, string favouriteLanguage, int id)
    {
        Name = name;
        FavouriteLanguage = favouriteLanguage;
        Id = id;
    }
    public Programmer ()
    {

    }
    public void SayHello()
    {
        Console.WriteLine("Hello i am " + Name + "and my favourite lenguage is " + FavouriteLanguage);
    }


}
    
    
    
    
