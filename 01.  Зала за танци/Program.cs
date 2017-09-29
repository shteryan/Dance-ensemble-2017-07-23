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
            double hallLenght = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());
            
            double hallLenghtCM = hallLenght * 100;
            double hallWidhtCM = hallWidth * 100;
            double wardrobeSideCM = wardrobeSide * 100;
            double dancerSpaceHeldCMSq = 40;
            double spaceForFreeDancingCMSq = 7000;
            
            double hallAreaCMSq = hallLenghtCM * hallWidhtCM;
            double benchAreaCMSq = hallAreaCMSq / 10;
            double wardrobeAreaCMSq = wardrobeSideCM * wardrobeSideCM;
            

            double hallFreeArea = hallAreaCMSq - (wardrobeAreaCMSq + benchAreaCMSq);
            
            int numberOfDancers = (int)(hallFreeArea / (dancerSpaceHeldCMSq + spaceForFreeDancingCMSq));
                        
            Console.WriteLine(numberOfDancers);
        }
    }
}
