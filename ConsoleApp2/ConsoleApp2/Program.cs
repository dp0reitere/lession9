using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Kā tevi sauc");
            string vards = Console.ReadLine();
            Console.WriteLine("Sveiki, " + vards);

            Console.WriteLine("Kāds ir tavs vecums?");
            int gadi = Convert.ToInt32(Console.ReadLine());
           
            int iepriekšgadagadi = gadi + 1;
            Console.WriteLine("Nākamgad Tev paliks" + " " + iepriekšgadagadi + " " + "gadi.");

            //---------------------------

            Console.WriteLine("Nosauciet trīs skaitļus");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            int skaitlis3 = Convert.ToInt32(Console.ReadLine());

            
            int lielakaisskaitlis = Math.Max(Math.Max(skaitlis3, skaitlis2),skaitlis1);
            Console.WriteLine("Lielākais skaitlis ir: " + lielakaisskaitlis);


            Console.WriteLine("Nosauciet trīs skaitļus");
            int skaitlis4 = Convert.ToInt32(Console.ReadLine());
            int skaitlis5 = Convert.ToInt32(Console.ReadLine());
            int skaitlis6 = Convert.ToInt32(Console.ReadLine());


            int mazakaisskaitlis = Math.Min(Math.Min(skaitlis4, skaitlis5), skaitlis6);
            Console.WriteLine("Mazākais skaitlis ir: " + mazakaisskaitlis);


            Console.WriteLine("Nosauciet divus skaitļus");
            int skaitlis7 = Convert.ToInt32(Console.ReadLine());
            int skaitlis8 = Convert.ToInt32(Console.ReadLine());

            int dalijumaatlikums = skaitlis7%skaitlis8;

            Console.WriteLine("Šo skaitļu dalījumaatlikums ir: " + dalijumaatlikums);

            Console.WriteLine("Nosauciet skaitli");
            int skaitlis9 = Convert.ToInt32(Console.ReadLine());
            if (skaitlis9%2 ==0)
            {
                Console.WriteLine("Šis ir pāra skaitlis");
            }
            else
            {
                Console.WriteLine("Šis ir nepāra skaitlis" );
            }
            Console.WriteLine("Nosauciet taisnstūra malu garumus");
            double skaitlis10 = Convert.ToDouble(Console.ReadLine());

                
            double skaitlis11 = Convert.ToDouble(Console.ReadLine());

            double Taisnsturalaukums = skaitlis10 * skaitlis11;
            double Taisnsturalaukums1 = Math.Round(Taisnsturalaukums, 2);

            Console.WriteLine("Taisnstūralaukums ir: " + Taisnsturalaukums1);






            Console.WriteLine("Nosauciet vienādsānutrijstūra malu garumus");
            double skaitlis12 = Convert.ToDouble(Console.ReadLine());
            double skaitlis13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nosauciet vienādsānutrijstūra augstumu");
            double skaitlis14 = Convert.ToDouble(Console.ReadLine());
            double trijsturalaukums = skaitlis10 * skaitlis11;

            Console.WriteLine("Taisnstūralaukums ir: " + Taisnsturalaukums);











        }
    }
}
