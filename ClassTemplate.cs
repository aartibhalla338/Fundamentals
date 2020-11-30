using System;
using System.Collections.Generic;
using System.Text;
/*85         /* decimal */
/*0213       /* octal */
/*0x4b       /* hexadecimal */
/*30         /* int */
/*30u        /* unsigned int */
/*30l        /* long */
/*30ul       /* unsigned long */
namespace example
{
    class ClassTemplate
    {
        //encapsulation<<<<<<<<<<Pillar OOB

        private string ps = "THis is the ps variable declared as Private";
        protected string protVar = "THis is the protVar variable declared as Protected";
        private int valTobeIncrease;
        private int startNum;
        //Constructor
        public ClassTemplate(decimal d)
        {
            Console.WriteLine("_________First Construct Case_________");
            Console.WriteLine(ps);
            Console.WriteLine(protVar);
            Console.WriteLine(d);
        }
        public ClassTemplate(decimal p, string s)
        {
            Console.WriteLine("_________Second Construct Case_________");
            Console.WriteLine(ps);
            Console.WriteLine(protVar);
            Console.WriteLine("This is instead P",p);
        }
        //Object Definition (Methods)
        public int increasevalfunc(int howmuchincrease)
        {
            Console.WriteLine("_________Object Method First Case_________");
            this.valTobeIncrease += howmuchincrease;
            Console.WriteLine(valTobeIncrease);
            return this.valTobeIncrease;
        }
        public void PrintToCento(int upNumtoIncrease)
        {
            
            Console.WriteLine("_________Object Method Second Case_________");
            startNum = this.increasevalfunc(20);
            for (int i=0; i < upNumtoIncrease;i++) 
            {
                startNum =+ startNum + i;
                Console.WriteLine(startNum);

            }
        }


    }
}
