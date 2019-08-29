using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable meeting ground
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";



            if (sample1 == sample2) //comparing samples
            {
                Console.WriteLine("The samples are equal.");
            }
            else Console.WriteLine("The samples are not equal.");



            if (heartRate >= 40 && heartRate <= 80) //checking if heart rate is optimal through two way comparison
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else Console.WriteLine("Heart rate is not normal.");



            if (deposits >= 100000000) //one way comparison
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else Console.WriteLine("Sorry you are so poor.");



            float force = mass * acceleration;
            Console.WriteLine("force = {0}", force); //calculating force



            Console.WriteLine("{0} is the distance", distance); //displaying distance



            if (lost == true && expensive == true) //two way comparison to give proper response based on two bools
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is a coupon for 10% off.");
            }



            switch (choice) //switch usage
            {
                case 1 :
                    Console.WriteLine("You chose 1.");
                    break;
                case 2 :
                    Console.WriteLine("You chose 2.");
                    break;
                case 3 :
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("What have you done?!");
                    break;
            }



            Console.WriteLine("{0} is an integral", integral); //displaying an integral



            for (int i = 5; i <= 10; i++) //for loop to count from 5 to 10
            {
                Console.WriteLine("i = {0}", i);
            }




            int age = 0; //while loop
            while (age < 6)
            {
                Console.WriteLine("age = {0}", age);
                age++;
            }




            Console.WriteLine("{0} {1}", greeting, name);

            Console.ReadKey();
        }
    }
}

