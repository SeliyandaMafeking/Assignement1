using System.ComponentModel.Design;

namespace Assignement1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BeerSong.Sing(99);

            /*for (int i = 99; i > 0; i--)
            {
                Console.WriteLine($"{bottles(i)} of beer on the wall, {WriteNumberOfBottles(i)} of beer");
                Console.WriteLine($"Take one down and pass it around, {WriteNumberOfBottles(i-1)} of beer on the wall");
            }
            
            

               static string WriteNumberOfBottles(int numberOfBottles )
            {
                if (numberOfBottles == 1)
                {
                    return "1 bottle";
                }
                else
                { 
                    return $"{numberOfBottles} bottles";
                }
               
            }*/
        }
    }
}
