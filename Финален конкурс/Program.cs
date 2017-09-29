using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Финален_конкурс
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take info from the user
            //1.Брой танцьори – цяло число в интервала[1…10];
            //2.Брой точки – реално число в интервала[1.00…10000.00];
            //3.Сезон – ”summer“ / “winter“;
            //4.Място – „Bulgaria“ / „Abroad“;

            double numberOfDancers = double.Parse(Console.ReadLine());            double points = double.Parse(Console.ReadLine());            string season = Console.ReadLine();            string place = Console.ReadLine();

            //Set up variables for the logical checks
            string summer = "summer";            string winter = "winter";            string bulgaria = "Bulgaria";            string abroad = "Abroad";

            //Set up variables for the calculations
            double winningPrice = 0;
            double expences = 0;

            //Make the logical checks and calculations for the price
            if (place == bulgaria)
            {
                winningPrice = points * numberOfDancers;
            }            else if (place == abroad)
            {
                winningPrice = points * numberOfDancers;
                double bonusAbroad = 0.5 * winningPrice;
                winningPrice += bonusAbroad;
            }

            //Make the logical checks and calculations for expences

            if (season == summer && place == bulgaria)
            {
                expences = 0.05;
            }            else if (season == winter && place == bulgaria)
            {
                expences = 0.08;
            }            else if (season == summer && place == abroad)
            {
                expences = 0.10;
            }            else if (season == winter && place == abroad)
            {
                expences = 0.15;
            }            //Make final calculations            expences = expences * winningPrice;            winningPrice -= expences;            double moneyForCharity = winningPrice * 0.75;            double priceFoundLeft = winningPrice - moneyForCharity;            double priceForADancer = priceFoundLeft / numberOfDancers;

            //Print the results on the console
            Console.WriteLine($"Charity - {moneyForCharity:F2}");            Console.WriteLine($"Money per dancer - {priceForADancer:F2}");


        }
    }
}
