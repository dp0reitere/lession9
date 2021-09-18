using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 15; // vesels skaitlis
            char myFavoriteletter = 'A';// simbols
            bool isCar = true; //loģiskais true/false
            double myConstant = 4.58; //decimalskaitlis
            float myChangingNum = 2.46f; //decimalskaitlis mazaks - mazak cipari aiz komata
            string name = "Artis dsfdsg sgdfsg nsfkj "; //teksts 


            Console.WriteLine(myNumber);
            Console.WriteLine(myFavoriteletter);
            Console.WriteLine(isCar);
            Console.WriteLine(myConstant);
            Console.WriteLine(myChangingNum);
            Console.WriteLine(name);

            Console.WriteLine(myConstant + myChangingNum);

            //---------------------------------------

            int myNumber1 = 4;
            int myNumber2 = 6;

            int sum1 = myNumber1 + myNumber2;
            Console.WriteLine(sum1);

            string name1 = "Helli";
            string name2 = "fromcode";

            string namesTogether = name1 + name2;

            Console.WriteLine(namesTogether);


            int withPluses = 4;
            withPluses++;

            Console.WriteLine(withPluses);

            int divisionreminder1 = 49;
            int divisionreminder2 = 10;

            int divisionreminderResult = divisionreminder1 % divisionreminder2;

            Console.WriteLine(divisionreminderResult);

            int myNumber5 = 14;
            int myNumber6 = 17;

            bool isEqualNumber = myNumber5 == myNumber6;

            Console.WriteLine(isEqualNumber);

            string myText4 = "ABC";
            string myText5 = "ABC";

            bool isEqualText = myText4 != myText5;

            Console.WriteLine(isEqualText);

            bool iamTrue = true;
            bool iamFalse = false;

            bool both = iamTrue && iamFalse;
            bool or = iamTrue || iamFalse;
            bool bothReversed = !both;

            Console.WriteLine(both);
            Console.WriteLine(or);
            Console.WriteLine(bothReversed);

            int myNumber9 = 14;
            myNumber9 += 10;
            Console.WriteLine(myNumber9);

            //-------------------------

            Console.WriteLine("What is your name");

            string username = Console.ReadLine();

            Console.WriteLine("Hi, " + username);

            Console.WriteLine("What is your age");

            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);
            int previosYearAge = age - 1;

            Console.WriteLine("Hi, last year you were: " + previosYearAge);




            int maxNumber1 = 4;
            int maxNumber2 = 6;

            int maxResult = Math.Max(maxNumber1, maxNumber2);
            Console.WriteLine(maxResult);

            int absWithMinus = -45;
            int absAfter = Math.Abs(absWithMinus);

            Console.WriteLine(absWithMinus);

            double numberToRound = 14.258;

            double rounded = Math.Round(numberToRound, 2);

            Console.WriteLine(rounded);


        }
    }
}
