using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Име_на_група
{
    class Program
    {
        static void Main(string[] args)
        {            
            char first = char.Parse(Console.ReadLine().ToUpper());
            char second = char.Parse(Console.ReadLine().ToLower());
            char third = char.Parse(Console.ReadLine().ToLower());
            char fourth = char.Parse(Console.ReadLine().ToLower());
            int fifth = int.Parse(Console.ReadLine());

            int count = -1;

            for (int firstSymbol = 'A'; firstSymbol <= first; firstSymbol++)
            {
                for (int secondSymbol = 'a'; secondSymbol <= second; secondSymbol++)
                {
                    for (int thirdSymbol = 'a'; thirdSymbol <= third; thirdSymbol++)
                    {
                        for (int fourthSymbol = 'a'; fourthSymbol <= fourth; fourthSymbol++)
                        {
                            for (int fifthSymbol = 0; fifthSymbol <= fifth; fifthSymbol++)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
