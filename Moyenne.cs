using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Moyenne
    {
        public List<int> ListEntiers { get; set; }
        public int N { get; set; }
   
        private List<int> ListInferieurN ()
        {
            List<int> resultat = ListEntiers.Where(x => x < N).ToList();
            return resultat; 
        }
        public double MoyenneListe ()
        {
         return ListInferieurN().Average();
        }
    }
}
