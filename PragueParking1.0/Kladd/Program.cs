using System;

namespace Kladd
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] ParkingLots = new string[101];
            { };

            for (var i = 1; i < 101; i++)
            {
                ParkingLots[i] = "EMPTY1 ; EMPTY2";
                Console.WriteLine(ParkingLots[i]);
            }
        }
    }
}
