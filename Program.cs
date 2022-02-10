// This program is created to convert a range of $0 to $200 Canadian Dollars to U.S. Dollars
// Program developed by: Mardochee Bellevue
using System;

namespace T_3___Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {            
            double USDollar;
            double incrementValue;
            double canadianDollar = 0;
            int maxCanadianDollar = 200;
            double UStoCAD = 0.792367;

            // prompt given to user to input increment value
            Console.WriteLine("Conversion from US Dollars to Canadian Dollars");
            Console.WriteLine("It will start at 0 CAD to 200 CAD");
            Console.WriteLine("Enter the value to increase the amount of Canadian dollars to increase by");
            Console.WriteLine("Value must be between the numbers 5 and 25");
            Console.WriteLine();

            // TryParse used to make sure increment value is not set to anything that is not a number
            // while loop is also used to make sure a number less than 5 or greater than 25 is not entered and give the user plenty of chances to correct their input
            while ( !(double.TryParse(Console.ReadLine(), out incrementValue)) || (incrementValue < 5 || incrementValue > 25) )
            {
                // prompt givent to user to input correct value
                Console.WriteLine();
                Console.WriteLine("Enter the value to increase the amount of canadian dollars to increase by");
                Console.WriteLine("Value must be between the numbers 5 and 25");
                Console.WriteLine();
            }

            // line written as a header to keep track of each currency's value
            Console.WriteLine();
            Console.WriteLine(String.Format("CAD Increment Value: {0}", incrementValue));
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-10} {1,20}", "CAD", "US Dollar"));

            // do-while loop used to print out the chart of the conversion starting from 0 Canadian dollars to a max of 200
            do
            {
                // equation used to convert Canadian dollars to U.S. dollars
                USDollar = canadianDollar * UStoCAD;
                // used to output the values in a certain format including the money symbol
                Console.WriteLine(String.Format("{0,-10:C} {1,20:C}", canadianDollar, USDollar));
                // equation to increase the canadian dollar by the increment value
                canadianDollar += incrementValue;

            } while (canadianDollar <= maxCanadianDollar);

        }
    }
}
