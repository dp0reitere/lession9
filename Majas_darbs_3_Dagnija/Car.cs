using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majas_darbs_3_Dagnija
{
    public class Car
    {
        public bool brauc { get; set; }
        public string marka { get; set; }
        public string numurzime { get; set; }
        public int atrums { get; set; }
        public bool Saktbraukt()
        {
            brauc = true;

            return brauc;
        }
        public int palielinaatrumu()
        {
            atrums = atrums+1;
            return atrums;
        }
        public bool beigtbraukt()
        {
            brauc = false;
            return brauc;
        }
        public int zamazinaatrumu()
        {
            atrums = atrums-1;
            return atrums;
        }
        public string taure()
        {
            string taure = "Beep beep";
            return taure;
        }
    }
}
