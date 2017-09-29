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
            double daysTraining = int.Parse(Console.ReadLine());
            double numberOfDancers = int.Parse(Console.ReadLine());                    
                              
            int currentDayOfTraining = 0;
            int hoursTrainingToday = 0;
            double energyWatedSoFar = 0;
            double energyToday = 0;        
            
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
                        
            double potentialCrewEnergy = 100 * daysTraining * numberOfDancers;
            double energyLeft = potentialCrewEnergy - energyWatedSoFar;
            double energyLeftPerDancerForADay = energyLeft / numberOfDancers / daysTraining;
                       
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
