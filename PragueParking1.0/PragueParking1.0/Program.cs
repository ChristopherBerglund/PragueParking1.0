using System;
using System.Collections.Generic;
using System.Threading;


namespace ArrayApplication
{
    class MyArray
    {
        static public void Main()
        {
            //Skapar en lista med 100 platser. 
            string[] ParkingSlots = new string[101];
            { };

            for (var i = 1; i < 101; i++)
            {
                ParkingSlots[i] = i + ".empty";
            }

            bool retry = true;
            while (retry)   //Om användaren ger ett felaktigt val, börjar programmet om.
            {
                //Användare-meny.
                Console.WriteLine("Welcome to Prague Parking");
                Console.WriteLine();
                Console.WriteLine("1. Park vehicle");
                Console.WriteLine("2. Unpark vehicle");
                Console.WriteLine();
                Console.WriteLine("3. Move a vehicle");
                Console.WriteLine("4. Search for a vehicle");
                Console.WriteLine("5. Check for free slots");
                Console.WriteLine();
                Console.WriteLine("6. Exit program (Admin only)");
                Console.WriteLine();
                Console.WriteLine("Choose a number and press \"enter\" for the desired selection:");
                string nOk = Console.ReadLine();
                int userChoice;
                Int32.TryParse(nOk, out userChoice);


                //Switch Meny.
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        string vehicletype = Console.ReadLine();
                        Console.WriteLine("Enter your license plate number:");
                        string vehicle = Console.ReadLine();
                        parkVehicle(vehicle, ParkingSlots);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter your license plate number:");
                        string vehicleOut = Console.ReadLine();
                        UnParkVehicle(vehicleOut, ParkingSlots);
                        break;
                    case 3:
                        Console.Clear();
                        moveVehicle();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter your license plate number:");
                        string vehicleOut1 = Console.ReadLine();
                        searchVehicle(vehicleOut1, ParkingSlots);
                        break;
                    case 5:
                        Console.Clear();
                        checkSlots(ParkingSlots);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Program is shutting down");
                        retry = false;
                        break;
                    default:
                        Console.Clear();
                        retry = true;
                        break;
                }
            }
        }

        //Parkerar/lägger till ett fordon.
        static void parkVehicle(string vehicle, string[] parkingSlots)
        {
            for (var i = 0; i < parkingSlots.Length; i++)
            {
                if (parkingSlots[i] == i + ".empty")
                {
                    parkingSlots[i] = i + "." + vehicle;
                    Console.Clear();
                    Console.WriteLine("Your license plate is: {0}, continue to parkinglot nr: {1}", vehicle, i);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
        }
                
        //Hämtar ut ett fordon från parkeringsplatsen.
        static void UnParkVehicle(string vehicleOut, string[] parkingSlots)
        {
            int sum = 0;
            for (var i = 0; i < parkingSlots.Length; i++)
            {
                if (parkingSlots[i] == i + "." + vehicleOut)
                {
                    parkingSlots[i] = i + ".empty";
                    Console.Clear();

                    Console.WriteLine("Your parking is ended, Welcome back!:", vehicleOut);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else
                {
                    sum++;
                }
                if (sum == 101)
                {
                    Console.Clear();
                    Console.WriteLine("No license plate matched");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }

        //Flyttar på ett fordon.
        static void moveVehicle()
        {
            Console.WriteLine("hej");
        }

        //Söker efter valt registeringsnummer.
        static void searchVehicle(string vehicleOut1, string[] ParkingSlots)
        {
            Console.Clear();
            int sum = 0;
            for (var i = 0; i < ParkingSlots.Length; i++)
            {
                if (ParkingSlots[i] == i + "." + vehicleOut1)
                {
                    Console.WriteLine("Your vehicle with plate number {0}, is placed in parking lot nr: {1}", vehicleOut1, i);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else
                {
                    sum++;
                }
                if(sum == 101)
                {
                    Console.WriteLine("No license plate matched");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }

        //Kollar antal lediga platser.
        static void checkSlots(string[] ParkingSlots)
        {
            int totalLots = 100;
            int freeLots = 0;
            for (var x = 0; x < ParkingSlots.Length; x++)
            {
                if (ParkingSlots[x] == x + ".empty")
                {
                    Console.WriteLine(ParkingSlots[x]);
                    freeLots++;
                }
                else
                {
                    Console.WriteLine(ParkingSlots[x]);
                }
            }
            Console.Clear();
            Console.WriteLine("There is {0} free spots out of {1} availble spots.", freeLots, totalLots);
            Thread.Sleep(3000);
            Console.Clear();
        }


    }
}

