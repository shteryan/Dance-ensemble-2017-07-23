using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Зала_за_танци
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take the parameters for the hall
            //1.L – дължина на залата в метри – реално число в интервала[10.00 … 100.00];
            //2.W – ширина на залата в метри – реално число в интервала[10.00 … 100.00];
            //3.А – страна на гардероба в метри – реално число в интервала[2.00… 20.00];
            double hallLenght = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            //Set up variables for the calculations
            double hallLenghtCM = hallLenght * 100;
            double hallWidhtCM = hallWidth * 100;
            double wardrobeSideCM = wardrobeSide * 100;
            double dancerSpaceHeldCMSq = 40;
            double spaceForFreeDancingCMSq = 7000;

            //Calculate the area of the hall and stuff
            double hallAreaCMSq = hallLenghtCM * hallWidhtCM;
            double benchAreaCMSq = hallAreaCMSq / 10;
            double wardrobeAreaCMSq = wardrobeSideCM * wardrobeSideCM;

            //Calculate the free space left

            double hallFreeArea = hallAreaCMSq - (wardrobeAreaCMSq + benchAreaCMSq);

            //Calculate the result
            int numberOfDancers = (int)(hallFreeArea / (dancerSpaceHeldCMSq + spaceForFreeDancingCMSq));

            //Print the result
            Console.WriteLine(numberOfDancers);
        }
    }
}
