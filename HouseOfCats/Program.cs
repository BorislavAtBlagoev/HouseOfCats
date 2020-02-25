using System;
using System.Collections.Generic;

namespace HouseOfCats
{
    class Program
    {
        static void Main(string[] args)
        {

            //alo new asd
            Console.WriteLine("How many legs are there in the house?");
            int legsInHouse = int.Parse(Console.ReadLine());

            //Guarantee that the value is correct.
            while (!(legsInHouse >= 0 && legsInHouse < 50) || legsInHouse % 2 != 0)
            {
                Console.WriteLine("Please enter valid value: ");
                legsInHouse = int.Parse(Console.ReadLine());
            }

            //Invoke the method and put it in an array.
            int[] possibleNumberOfHumansInHouse = CalculateNumberOfHumans(legsInHouse);

            Console.WriteLine("The possible number of humans in the house.");
            //Prints the possible number of humans in the house.
            foreach (var numberOfHumans in possibleNumberOfHumansInHouse)
            {
                Console.Write($"{numberOfHumans}, ");
            }

        }

        //Method to calculate the number of people in the house.
        public static int[] CalculateNumberOfHumans(int legsInHouse)
        {
            int currentNumberOfHumans;

            List<int> possibleNumberOfHumans = new List<int>();

            while (legsInHouse >= 0)
            {
                currentNumberOfHumans = legsInHouse / 2;
                possibleNumberOfHumans.Add(currentNumberOfHumans);
                legsInHouse -= 4;
            }

            possibleNumberOfHumans.Reverse();
            return possibleNumberOfHumans.ToArray();
        }

    }
}
