using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majas_darbs_3_Dagnija
{
    class Persona
    {
        public string vards { get; set; }
        public string uzvards { get; set; }
        public int dzimsanasgads { get; set; }
        public string hobijs { get; set; }
        public bool IrVirietis { get; set; }
        public int gadi { get; set; }
        
        public string sasveicinaties()
        {
            gadi = 2021 - dzimsanasgads;
            string saisvecinasanas = "Hello my name is " + vards + " " + uzvards + " and I am " + gadi + ".";
            return saisvecinasanas;
        }

    }
}
