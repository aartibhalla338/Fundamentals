
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class MemoryDataSource : IDataSource<Programmer>
{
    private List<Programmer> programmers = new List<Programmer>();
    public MemoryDataSource()
    {
        Programmer p1 = new Programmer("Mattia", "C#",1);
        Programmer p2 = new Programmer("Riccardo","C#",2);
        Programmer p3 = new Programmer("Matteo", "Python",3);
        
        programmers.Add(p1);
        programmers.Add(p2);
        programmers.Add(p3);
    }
    public List<Programmer> ReadAll()
   
    {
        return programmers;
    }
    public Programmer FindById(int id)
    {
        /*for (int i=0; i<programmers.Count; i++)
        {
            if (id==programmers[i].Id)
                return programmers[i];
        }
        return null;

        foreach (var p in programmers)
        {
            if (id==p.Id)
            {
                return p;
            }
            
        }
        return null;*/
        Enumerable.SingleOrDefault(programmers, p => p.Id==id);
        // extension method
        return programmers.SingleOrDefault( p => p.Id == id);
        

       
    }
}
    
    
    