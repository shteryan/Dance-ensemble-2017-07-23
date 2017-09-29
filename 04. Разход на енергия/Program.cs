using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Разход_на_енергия
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take info form the user
            //1.N – брой тренировъчни дни – цяло число в интервала[0 … 31].
            //2.А – брой танцьори – цяло число в интервала[0 … 100].

            double daysTraining = int.Parse(Console.ReadLine());
            double numberOfDancers = int.Parse(Console.ReadLine());                    
            
            //Set up variables for the calculations      
            int currentDayOfTraining = 0;
            int hoursTrainingToday = 0;
            double energyWatedSoFar = 0;
            double energyToday = 0;        
            
            //Make the logical checks and take training hours info
            for (currentDayOfTraining = 1; currentDayOfTraining <= daysTraining; currentDayOfTraining++)
            {
                hoursTrainingToday = int.Parse(Console.ReadLine());

                bool evenDay = currentDayOfTraining % 2 == 0;
                bool oddDay = currentDayOfTraining % 2 == 1;
                bool evenHours = hoursTrainingToday % 2 == 0;
                bool oddHours = hoursTrainingToday % 2 == 1;

                if (evenDay && evenHours)
                {
                    energyToday = 68;
                }
                else if (evenDay && oddHours)
                {
                    energyToday = 65;
                }
                else if (oddDay && evenHours)
                {
                    energyToday = 49; 
                }
                else if (oddDay && oddHours)
                {
                    energyToday = 30;
                }
                double energyWastedToday = numberOfDancers * energyToday;
                energyWatedSoFar += energyWastedToday;
            }

            //Make the final calculations
            double potentialCrewEnergy = 100 * daysTraining * numberOfDancers;
            double energyLeft = potentialCrewEnergy - energyWatedSoFar;
            double energyLeftPerDancerForADay = energyLeft / numberOfDancers / daysTraining;

            //Print the result on the console
            if (energyLeftPerDancerForADay <= 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {energyLeftPerDancerForADay:F2}");
            }
            else if (energyLeftPerDancerForADay > 50)
            {
                Console.WriteLine($"They feel good! Energy left: {energyLeftPerDancerForADay:F2}");
            }

        }
    }
}
