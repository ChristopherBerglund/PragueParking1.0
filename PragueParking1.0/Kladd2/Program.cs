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
            string[] ParkingSlots = new string[101]; { };
            for (var i = 1; i < 101; i++)
            {
                ParkingSlots[i] = "EMPTY1 ; EMPTY2";
            }

            bool retry = true;
            while (retry)   //Om användaren ger ett felaktigt val, börjar programmet om.
            {
                //Användare-meny.
                Console.Clear();
                Console.WriteLine("Welcome to Prague Parking");
                Console.WriteLine();
                Console.WriteLine("1. Park vehicle");
                Console.WriteLine("2. Unpark vehicle");
                Console.WriteLine();
                Console.WriteLine("3. Move a vehicle");
                Console.WriteLine("4. Search for a vehicle");
                Console.WriteLine("5. Check for free slots");
                Console.WriteLine("6. Check all slots");
                Console.WriteLine();
                Console.WriteLine("7. Exit program (Admin only)");
                Console.WriteLine();
                Console.WriteLine("Choose a number and press \"enter\" for the desired selection:");
                string Hej = Console.ReadLine();
                int userChoice;
                Int32.TryParse(Hej, out userChoice);


                //Användarens val går till switchEn.
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        int Type = int.Parse(Console.ReadLine().ToUpper());


                        if (Type == 2)
                        {
                            Console.WriteLine("Enter your 10 letter license plate number:");
                            string vehicle = Console.ReadLine().ToUpper();
                            if (vehicle.Length == 10)
                            {
                                parkVehicleMC(Type, vehicle, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("The license plate number must be 10 letters, try again.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        }
                        else if (Type == 1)
                        {
                            Console.WriteLine("Enter your 10 letter license plate number:");
                            string vehicle1 = Console.ReadLine().ToUpper();
                            if (vehicle1.Length == 10)
                            {
                                parkVehicle(Type, vehicle1, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("The license plate number must be 10 letters, try again.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        int Type1 = int.Parse(Console.ReadLine().ToUpper());

                        if (Type1 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter your 10 letter license plate number:");
                            string vehicle = Console.ReadLine().ToUpper();
                            if (vehicle.Length == 10)
                            {
                                unParkVehicleMC(Type1, vehicle, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The license plate number must be 10 letters, try again.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        }
                        else if (Type1 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter your 10 letter license plate number:");
                            string vehicle1 = Console.ReadLine().ToUpper();
                            if (vehicle1.Length == 10)
                            {
                                unParkVehicle(Type1, vehicle1, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The license plate number must be 10 letters, try again.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input, try again.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                       
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter license plate number:");
                        string vehicleMove = Console.ReadLine().ToUpper();
                        moveVehicle(vehicleMove, ParkingSlots);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        int Type2 = int.Parse(Console.ReadLine().ToUpper());

                        if (Type2 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter your 10 letter license plate number:");
                            string vehicle = Console.ReadLine().ToUpper();
                            if (vehicle.Length == 10)
                            {
                                searchVehicleMC(Type2, vehicle, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The license plate number must be 10 letters, try again.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        }
                        else if (Type2 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter your 10 letter license plate number:");
                            string vehicle1 = Console.ReadLine().ToUpper();
                            if (vehicle1.Length == 10)
                            {
                               searchVehicle(Type2, vehicle1, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The license plate number must be 10 letters, try again.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input, try again.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                        
                    case 5:
                        Console.Clear();
                        checkSlots(ParkingSlots);
                        break;
                    case 6:
                        Console.Clear();
                        ShowAll(ParkingSlots);
                        break;
                    case 7:
                        Console.Clear();
                        retry = false;
                        break;
                        //Console.Write("Enter Password:");
                        //string InputPassword = Console.ReadLine();
                        //string passWord = "admin";
                        //if (InputPassword == passWord)
                        //{
                        //    Console.WriteLine("Program is shutting down");
                        //    retry = false;
                        //    break;
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Wrong username or password.");
                        //    Thread.Sleep(3000);
                        //    Console.Clear();
                        //    break;
                        //}
                    default:
                        Console.Clear();
                        retry = true;
                        break;
                }
            }
        }

        //Parkerar/lägger till ett fordon********************************
        static void parkVehicleMC(int Type, string vehicle, string[] ParkingSlots)
        {
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Substring(0, 6) == "EMPTY1")
                {
                    ParkingSlots[y] = ParkingSlots[y].Replace("EMPTY1", vehicle);
                    Console.Clear();
                    Console.WriteLine("Vehicle with license nr: {0} is parked in slot:{1}", vehicle, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else if (ParkingSlots[y].Length > 13 && ParkingSlots[y].Substring(13, 6) == "EMPTY2")
                {
                    ParkingSlots[y] = ParkingSlots[y].Replace("EMPTY2", vehicle);
                    Console.Clear();
                    Console.WriteLine("Vehicle with license nr: {0} is parked in slot:{1}", vehicle, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
        }
        static void parkVehicle(int Type, string vehicle1, string[] ParkingSlots)
        {
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y] == "EMPTY1 ; EMPTY2")
                {
                    ParkingSlots[y] = ParkingSlots[y].Replace("EMPTY1 ; EMPTY2", vehicle1);

                    Console.WriteLine("Vehicle with license nr: {0} is parked in slot:{1}", vehicle1, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
        }
        //Hämtar ut ett fordon från parkeringsplatsen********************************
        static void unParkVehicleMC(int Type1, string vehicle, string[] ParkingSlots)
        {
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Substring(0, 10) == vehicle)
                {
                    ParkingSlots[y] = ParkingSlots[y].Replace(vehicle, "EMPTY1");
                    Console.Clear();
                    Console.WriteLine("Vehicle with license nr: {0}, Welcome back!", vehicle, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else if (ParkingSlots[y].Length > 13 && ParkingSlots[y].Substring(13, 10) == vehicle)
                {
                    ParkingSlots[y] = ParkingSlots[y].Replace(vehicle, "EMPTY2");
                    Console.Clear();
                    Console.WriteLine("Vehicle with license nr: {0}, Welcome back!", vehicle, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Your license nr wasnt found, please try again.");
                }
            }
        }
        static void unParkVehicle(int Type1, string vehicle1, string[] ParkingSlots)
        {
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y] == vehicle1)
                {
                    ParkingSlots[y] = ParkingSlots[y].Replace(vehicle1, "EMPTY1 ; EMPTY2");

                    Console.WriteLine("Vehicle with license nr: {0}, Welcome back!", vehicle1);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
        }
        //Flyttar på ett fordon.
        static void moveVehicle(string vehicleMove, string[] ParkingSlots)
        {
            Console.Clear();
            int sum = 0;
            for (var i = 0; i < ParkingSlots.Length; i++)
            {
                if (ParkingSlots[i] == i + "." + vehicleMove)
                {
                    Console.Clear();
                    Console.WriteLine("Vehicle {0}, is parked at lot-nr: {1}", vehicleMove, i);
                    Console.WriteLine("Enter witch parkingslotnumber to move vehicle: ");
                    int moveNr = int.Parse(Console.ReadLine());
                    if (ParkingSlots[moveNr] == moveNr + "." + "empty")
                    {
                        ParkingSlots[i] = i + ".empty";
                        ParkingSlots[moveNr] = moveNr + "." + vehicleMove;
                        Console.Clear();
                        Console.WriteLine("Vehicle is succesfully moved from lot-nr {1} to lot-nr {2}", vehicleMove, i, moveNr);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lot-nr {0} is not empty, choose another lot.",moveNr);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    
                }
                else
                {
                    sum++;
                }
                if (sum == 101)
                {
                    Console.WriteLine("No license plate matched");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }

        }

        //Söker efter valt registeringsnummer. ********************************
        static void searchVehicleMC(int Type2, string vehicle, string[] ParkingSlots)
        {
            
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Substring(0, 10) == vehicle)
                {
                    Console.Clear();
                    Console.WriteLine("Vehicle with license nr: {0}, is parked in slot: {1}.", vehicle, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else if (ParkingSlots[y].Length > 13 && ParkingSlots[y].Substring(13, 10) == vehicle)
                {
                    Console.Clear();
                    Console.WriteLine("Vehicle with license nr: {0}, is parked in slot: {1}.", vehicle, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No license number matched");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }
        static void searchVehicle(int Type2, string vehicle1, string[] ParkingSlots)
        {
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y] == vehicle1)
                {
                    Console.Clear();
                    Console.WriteLine("Vehicle with license nr: {0}, is parked int slot:{1}", vehicle1, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No license number matched");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }
            
        //Kollar antal lediga platser.
        static void checkSlots(string[] ParkingSlots)
        {
            int Total = 100;
            int freeSlots = 0;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y] == "EMPTY1 ; EMPTY2")
                {
                    freeSlots++;
                }
                else
                {

                }
            }
            Console.Clear();
            Console.WriteLine("{0} free parkings out of {1}.", freeSlots, Total);
            Thread.Sleep(3000);
            Console.Clear();
        }
        static void ShowAll(string[] ParkingSlots)
            {
            for (var x = 0; x < ParkingSlots.Length; x++)
            {
                Console.WriteLine(ParkingSlots[x]);
            }
            Thread.Sleep(5000);
            Console.Clear();


        }
       


    }
}

