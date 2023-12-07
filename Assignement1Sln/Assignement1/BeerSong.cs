using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    internal class BeerSong
    {
        public static string Sing(int numberOfBottles)
        {
            for (int i = 99; i > 1; i--)
            { 
                Console.WriteLine($"{WriteNumberOfBeer(i)} of beer on the wall, {WriteNumberOfBeer(i)} of beer");
                Console.WriteLine($"Take one down and pass it around, {WriteNumberOfBeer(i - 1)} of beer on the wall");
                Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer");
            }


           static string WriteNumberOfBeer(int numberOfBottles)
            { 
                if (numberOfBottles == 1)
                {
                    return "1 bottle";
                }
                else
                {
                    return $"{numberOfBottles} bottles";
                }
            }
        
            return "";
        }
    }
}
