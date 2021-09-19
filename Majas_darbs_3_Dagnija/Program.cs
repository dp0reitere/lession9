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


            Console.WriteLine("________________________________________________________");


            Car mana = new Car();
            mana.brauc = false;
            mana.marka = "Skoda";
            mana.numurzime = "FW - 9823";
            mana.atrums = 60;
            Console.WriteLine(mana.brauc);
            Console.WriteLine(mana.marka);
            Console.WriteLine(mana.numurzime);
            Console.WriteLine(mana.atrums);
            Console.WriteLine(mana.Saktbraukt());
            Console.WriteLine(mana.palielinaatrumu());
            Console.WriteLine(mana.zamazinaatrumu());
            Console.WriteLine(mana.taure());
            Console.WriteLine(mana.beigtbraukt());


            Console.WriteLine("________________________________________________________________");

            Persona es = new Persona();
            Console.WriteLine("Ieraksti savu vardu.");
            es.vards = Console.ReadLine();
            Console.WriteLine("Ieraksti savu uzvardu.");
            es.uzvards = Console.ReadLine();
            Console.WriteLine("Ieraksti kurā gada tu esi dzimis.");
            es.dzimsanasgads = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kads tavs hobijs.");
            es.hobijs = Console.ReadLine();
            Console.WriteLine("Vai tu esi vīrietis? true or false.");
            es.IrVirietis = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(es.sasveicinaties());
            Console.WriteLine("_________________________________________________________________");
            Prece gurķis = new Prece();

            Console.WriteLine("Nosauc preces garumu.(cm)");
            gurķis.garums = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nosauc preces platumu.(cm)");
            gurķis.platums = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nosauc preces svaru.(kg)");
            gurķis.svars = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Preces garums - " + gurķis.garums + " cm");
            Console.WriteLine("Preces platums - " + gurķis.platums + " cm");
            Console.WriteLine("Preces svars - " + gurķis.svars + " kg");

        }
    }
}
