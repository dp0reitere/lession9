using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majas_darbs_3_Dagnija
{
    public class Telefons
    {
        public string Marka { get; set; }

        public string Modelis { get; set; }

        public string augstums { get; set; }

        public string Call()
        {
            string call = Modelis + "calling";

            return call;

        }

        public string Sendsms()
        {
            string sendsms = Modelis + "sending sms";

            return sendsms;

        }

    }
}
