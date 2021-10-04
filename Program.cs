using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Moyenne moyenne = new Moyenne();
            moyenne.ListEntiers = new List<int>();
            moyenne.ListEntiers.Add(12);
            moyenne.ListEntiers.Add(15);
            moyenne.ListEntiers.Add(11);
            moyenne.ListEntiers.Add(16);
            moyenne.ListEntiers.Add(2);

            moyenne.N = 12;
            
            foreach(int note in moyenne.ListEntiers)
            {
                Console.WriteLine(note);
            }
            
            Console.WriteLine(moyenne.MoyenneListe());

            Console.ReadLine();

        }
    }
}
