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
            double numberOfDancers = double.Parse(Console.ReadLine());            double points = double.Parse(Console.ReadLine());            string season = Console.ReadLine();            string place = Console.ReadLine();
            
            string summer = "summer";            string winter = "winter";            string bulgaria = "Bulgaria";            string abroad = "Abroad";
            
            double winningPrice = 0;
            double expences = 0;
            
            if (place == bulgaria)
            {
                winningPrice = points * numberOfDancers;
            }            else if (place == abroad)
            {
                winningPrice = points * numberOfDancers;
                double bonusAbroad = 0.5 * winningPrice;
                winningPrice += bonusAbroad;
            }
            
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
            }                                    expences = expences * winningPrice;            winningPrice -= expences;            double moneyForCharity = winningPrice * 0.75;            double priceFoundLeft = winningPrice - moneyForCharity;            double priceForADancer = priceFoundLeft / numberOfDancers;
            
            Console.WriteLine($"Charity - {moneyForCharity:F2}");            Console.WriteLine($"Money per dancer - {priceForADancer:F2}");


        }
    }
}
