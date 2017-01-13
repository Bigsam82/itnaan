using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project__ithnaan
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name ");
            string firstName = (Console.ReadLine());
            Console.WriteLine("What is last name ");
            string lastName = (Console.ReadLine());

            Console.WriteLine("Greetings Your Excellancy" +" " + firstName + " "+ lastName);

            Console.WriteLine("What is your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birth month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite ROYGBIV color,if you don't know what a ROYGBIV color is type HELP");
            string roygbiv = (Console.ReadLine());


            if (roygbiv == "help")
            {
                Console.WriteLine("If you do not know what ROYGBIV colors they are one of the following \n red, \n orange, \n yellow,\n green, \n blue,\n indigo, \n violet");
                roygbiv = (Console.ReadLine());

            }
            roygbiv.ToLower();
            Console.WriteLine("How many siblings do you have");
            int siblings = int.Parse(Console.ReadLine());



            string retired = "";
            if (age % 2 == 0)

            {



                retired = "you retire in 10 years";

            }

            else
            {
                retired = "you retire in 20 years";
            }

            string vacay = "";
            if (siblings == 0)

            {
                vacay = "you have a vacation home in florida";
            }

            else if (siblings == 1)

            {

                vacay = "you have a vaction home in mexico";
            }


            else if (siblings == 2)

            {
                vacay = "you have a vacation home in Germany";
            }


            else if (siblings == 3)

            {
                vacay = "you have a vacation home in Dubai";
            }


            else if (siblings == 3)


            {

                vacay = "you have a vaction home in Tha CLEVE";
            }
            if (siblings >= 4)
            {

                vacay = "you have a vaction home in Iraq";
            }
            string ride = "";
            if (roygbiv == "red")

            {
                ride = "You own a boat";

            }


            else if (roygbiv == "orange")

            {
                ride = "you own a car";
            }


            else if (roygbiv == "yellow")

            {
                ride = "you own a bike";
            }


            else if (roygbiv == "green")

            {
                ride = "you own a scooter";
            }


            if (roygbiv == "blue")

            {
                ride = "you have skates";

            }


            if (roygbiv == "indigo")

            {
                ride = " you have a plane ";

            }


            if (roygbiv == "violet")

            {
                ride = " you have a spaceship ";
            }
            string bank = "";
            if (month < 5 && month > 0)

            {
                bank = " You have $100k in the bank ";
            }

            if (month <= 8 && month >= 5)
            {
                bank = " you have $500k in the bank ";
            }
            if (month < 8 && month > 12)
            {
                bank = " You have $1.5 million in the bank ";
            }
            if (month <= 0)
            {
                bank = " You will have $0 in the bank ";
            }


            Console.WriteLine(firstName + " " + lastName + " " + retired + " " + bank + " " + ride + vacay);

        }
    }
}





       
    

