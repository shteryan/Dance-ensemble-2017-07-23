using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Купа
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            
            int objectWidth = 5 * size;
            int cupRow = 3 * size - 2;
            
            char hashtag = '#';
            char dot = '.';
            string danceSign = "D^A^N^C^E^"; 
            string rowToPrint = string.Empty;


            for (int currentRow = 1; currentRow <= size / 2; currentRow++)
            {
                rowToPrint = string.Format("{0}#{1}#{0}",
                                                                new string(dot, (objectWidth - cupRow - 2) / 2),
                                                                new string(hashtag, cupRow));
                cupRow -= 2;
                Console.WriteLine(rowToPrint);
            }
            for (int currentRow = 1; currentRow <= size / 2 + 1; currentRow++)
            {
                rowToPrint = string.Format("{0}#{1}#{0}",
                                                                new string(dot, (objectWidth - cupRow - 2) / 2),
                                                                new string(dot, cupRow));
                cupRow -= 2;
                Console.WriteLine(rowToPrint);
            }
            cupRow += 2;
            rowToPrint = string.Format("{0}#{1}#{0}",
                                                                new string(dot, (objectWidth - cupRow - 2) / 2),
                                                                new string(hashtag, cupRow));
            Console.WriteLine(rowToPrint);
            cupRow += 4;
            for (int currentRow = 1; currentRow <= size / 2; currentRow++)
            {
                rowToPrint = string.Format("{0}#{1}#{0}",
                                                                new string(dot, (objectWidth - cupRow - 2) / 2),
                                                                new string(hashtag, cupRow));
                Console.WriteLine(rowToPrint);
            }
            rowToPrint = string.Format("{0}{1}{0}",
                                                                new string(dot, (objectWidth - 10) / 2),
                                                               danceSign);
            Console.WriteLine(rowToPrint);
            for (int currentRow = 1; currentRow <= size / 2 + 1; currentRow++)
            {
                rowToPrint = string.Format("{0}#{1}#{0}",
                                                                new string(dot, (objectWidth - cupRow - 2) / 2),
                                                                new string(hashtag, cupRow));
                Console.WriteLine(rowToPrint);
            }
        }
    }
}
