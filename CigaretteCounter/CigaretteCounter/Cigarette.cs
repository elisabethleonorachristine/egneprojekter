using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CigaretteCounter
{
    public class Cigarette
    {
        public int TotalCigs;
        public int CigsToday;

        public Cigarette(int totalCigs, int cigsToday)
        {
            TotalCigs = totalCigs;
            CigsToday = cigsToday;
        }

        public void AddCig()
        {
            Console.WriteLine("Enter number of cigs to add:");
            string cigNum = Console.ReadLine();
            int cigNumInt = Int32.Parse(cigNum);
            if (cigNumInt > 0)
            {
                Cigarette newCig = new Cigarette(TotalCigs, cigNumInt);
                TotalCigs += cigNumInt;
                Console.WriteLine($"You now have smoked {TotalCigs} cigarettes in total.");
            }
            
        }
        
        
   
    } 
    
    
} 
