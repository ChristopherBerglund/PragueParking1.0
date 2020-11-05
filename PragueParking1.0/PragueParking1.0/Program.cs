using System;
using System.Collections.Generic;
using System.Threading;


namespace ArrayApplication
{
    class MyArray
    {
        static public void Main()
        {

            string[] ParkingSlots = new string[101];
            { };

            for (var i = 1; i < 101; i++)
            {
                ParkingSlots[i] = i + ".empty";
            }



            bool retry = true;
            while (retry)   //Om användaren ger ett felaktigt val, börjar programmet om.
            {
                
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
                
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        string vehicletype = Console.ReadLine();
                        Console.WriteLine("Enter your regplate number:");
                        string vehicle = Console.ReadLine();
                        parkVehicle(vehicle, ParkingSlots);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter your regplate number:");
                        string vehicleOut = Console.ReadLine();
                        UnParkVehicle(vehicleOut, ParkingSlots);
                        break;
                    case 3:
                        Console.Clear();
                        moveVehicle();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter your regplate number:");
                        string vehicleOut1 = Console.ReadLine();
                        searchVehicle(vehicleOut1, ParkingSlots);
                        break;
                    case 5:
                        checkSlots();
                        break;
                    case 6:
                        Console.WriteLine("Program is shutting down");
                        retry = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Something went wrong, try again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        retry = true;
                        break;
                }
            }
        }

        static void parkVehicle(string vehicle, string[] parkingSlots)
        {






            for (var i = 0; i < parkingSlots.Length; i++)
            {
                if (parkingSlots[i] == i + ".empty")
                {
                    parkingSlots[i] = i + "." + vehicle;
                    Console.Clear();
                    Console.WriteLine("Your licence plat is: {0}, continue to parkinglot-nr: {1}", vehicle, i);
                    Thread.Sleep(3000);
                    Console.Clear();
                   
                    
                    break;
                }
            }

            //for (var x = 0; x < parkingSlots.Length; x++)
            //{
            //    Console.WriteLine(parkingSlots[x]);
            //}


        }
                
            
        

        static void UnParkVehicle(string vehicleOut, string[] parkingSlots)
        {
            int sum = 0;
            for (var i = 0; i < parkingSlots.Length; i++)
            {
                if (parkingSlots[i] == i + "." + vehicleOut)
                {
                    parkingSlots[i] = i + ".empty";
                    Console.Clear();

                    Console.WriteLine("Your licence plat is: {0}, Welcome back!:", vehicleOut);
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
                    Console.WriteLine("No platenumber matched");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }

            //for (var x = 0; x < parkingSlots.Length; x++)
            //{
            //    Console.WriteLine(parkingSlots[x]);
            //}
        }
        static void moveVehicle()
        {
            Console.WriteLine("hej");
        }
        static void searchVehicle(string vehicleOut1, string[] ParkingSlots)
        {
            Console.Clear();
            int sum = 0;
            for (var i = 0; i < ParkingSlots.Length; i++)
            {
                if (ParkingSlots[i] == i + "." + vehicleOut1)
                {
                    Console.WriteLine("Your car {0}, is placed in carlot nr: {1}", vehicleOut1, i);
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
                    Console.WriteLine("No platenumber matched");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                
            }
           
            //Array.Sort(ParkingSlots);
            //int index = Array.BinarySearch(ParkingSlots, vehicleOut1);

            //Console.WriteLine(index);
        }
        static void checkSlots()
        {
            Console.WriteLine("hej");

        }


    }
}

