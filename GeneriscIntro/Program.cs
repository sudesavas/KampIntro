using System;
using System.Collections.Generic;

namespace GeneriscIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<String> isimler = new MyList<string>();
            isimler.Add("Engin");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);


        }
    }
}
