﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Хореография
{
    class Program
    {
        static void Main(string[] args)
        {                        
            double numberOfSteps = double.Parse(Console.ReadLine());
            double numberOfDancers = double.Parse(Console.ReadLine());
            double numberOfDaysToPractice = double.Parse(Console.ReadLine());
                                   
            double stepsForADay = Math.Ceiling(100 * ((numberOfSteps / numberOfDaysToPractice) / numberOfSteps));
            bool thereIsEnoughTime = stepsForADay <= 13;
            double percentOfStepsPerDancer = stepsForADay / numberOfDancers;
                        
            if (thereIsEnoughTime)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentOfStepsPerDancer:f2}%.");
            }
            else if (!thereIsEnoughTime)
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {percentOfStepsPerDancer:f2}% steps to be learned per day.");
            }
        }
    }
}
