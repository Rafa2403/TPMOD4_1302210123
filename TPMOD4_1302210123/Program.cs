using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4_1302210123
{
    internal class Program
    {
        public class Kodebuah
        {
            public enum namaBuah { 
                Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung  
            }
            public static string getKodeBuah(namaBuah kode)
            {
                string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
                return kodeBuah[(int)kode];
            }
        }
        
    }
}
