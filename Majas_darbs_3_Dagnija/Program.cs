using System;

namespace Majas_darbs_3_Dagnija
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefons mammastelefons = new Telefons();

            mammastelefons.Marka = "Samsung";
            mammastelefons.Modelis = "Galaxy S9+";
            mammastelefons.augstums = "15";

            string callingphone = mammastelefons.Call();
            Console.WriteLine(callingphone);

            //string sendingsms = mammastelefons.Sendsms();
            Console.WriteLine(mammastelefons.Sendsms());

            Telefons manstelefons = new Telefons();

            manstelefons.Marka = "IPhone";
            manstelefons.Modelis = "7S";
            manstelefons.augstums = "11";

            string callingphone1 = manstelefons.Call();
            Console.WriteLine(callingphone1);

            string sendingsms1 = manstelefons.Sendsms();
            Console.WriteLine(sendingsms1);

        }
    }
}
