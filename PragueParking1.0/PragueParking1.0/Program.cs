using System;
using System.Collections.Generic;
using System.Threading;


namespace ArrayApplication
{
    class MyArray
    {
        static public void Main()
        {
            ////////////////////////////////////////////////////////////////////////

            //** Lösenord för att avsluta programmet: admin 

            //Programmet använder Threading, så efter avslutad metod/text, tar det mellan 3-5 sekunder innan
            //programmet går vidare alt återgår till huvudmenyn, detta för att användaren aldrig ska fastna.

            ////////////////////////////////////////////////////////////////////////

            Console.ForegroundColor = ConsoleColor.White;
            string[] ParkingSlots = new string[101]; { };
            for (var i = 1; i < 101; i++)
            {
                ParkingSlots[i] = i + "." + "EMPTY1 - EMPTY2";
            }

            
            bool retry = true;
            while (retry)   
            {
                Console.Clear();
                Console.WriteLine("Welcome to Prague Parking");
                Console.WriteLine();
                Console.WriteLine("[1] Park vehicle");
                Console.WriteLine("[2] Unpark vehicle");
                Console.WriteLine();
                Console.WriteLine("[3] Move a vehicle");
                Console.WriteLine("[4] Search for a vehicle");
                Console.WriteLine("[5] Check for free lots");
                Console.WriteLine("[6] Check all lots");
                Console.WriteLine();
                Console.WriteLine("[7] Exit program (Admin only)");
                Console.WriteLine();
                Console.WriteLine("Choose a number and press \"enter\" for the desired selection:");
                string input = Console.ReadLine();int userChoice;Int32.TryParse(input, out userChoice);
                switch (userChoice)
                {
                    case 1: //Parkera Fordon.
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        string typ = Console.ReadLine().ToUpper(); int Type; Int32.TryParse(typ, out Type);
                        Console.WriteLine("Enter your license number:");
                        string vehicle = Console.ReadLine().ToUpper();
                        bool IsValid = true;
                        for (var i = 1; i < ParkingSlots.Length; i++)
                        {
                            if (ParkingSlots[i].Contains(vehicle))
                            {
                                IsValid = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The license-number already exist.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(4000);
                                break;
                            }
                        }
                        if (IsValid == true)
                        {
                            for (var i = 1; i < ParkingSlots.Length; i++)
                            {
                                if (vehicle.Length <= 10 && vehicle.Length >= 3 && Type == 2 && vehicle.Length > 3)
                                {
                                    parkVehicleMC(Type, vehicle, ParkingSlots);
                                    break;
                                }
                                else if (vehicle.Length <= 10 && vehicle.Length >= 3 && Type == 1 && vehicle.Length > 3)
                                {
                                    parkVehicle(Type, vehicle, ParkingSlots);
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid input, try again.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Thread.Sleep(4000);
                                    Console.Clear();
                                    break;
                                }
                            }
                        }
                       break;
                    case 2://Avparkera fordon.
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        string typ1 = Console.ReadLine().ToUpper();int Type1;Int32.TryParse(typ1, out Type1);

                        if (Type1 == 2)//Avparkera bil.
                        {
                            Console.Clear();
                            Console.WriteLine("Enter your license number:");
                            string vehicle1 = Console.ReadLine().ToUpper();
                            if (vehicle1.Length <= 10 && vehicle1.Length > 3)
                            {
                                unParkVehicleMC(Type1, vehicle1, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The license number is not valid, try again.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        }
                        else if (Type1 == 1) //Avparkera MC.
                        {
                            Console.Clear();
                            Console.WriteLine("Enter your license number:");
                            string vehicle1 = Console.ReadLine().ToUpper();
                            if (vehicle1.Length <= 10 && vehicle1.Length > 3)
                            {
                                unParkVehicle(Type1, vehicle1, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The license number is not valid, try again.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input, try again.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 3://Flytta Bil:
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        string typ2 = Console.ReadLine().ToUpper(); int Type3; Int32.TryParse(typ2, out Type3);

                        if(Type3 == 1)
                        {
                            Console.WriteLine("Enter license number:");
                            string vehicleMove = Console.ReadLine().ToUpper();
                            moveVehicle(vehicleMove, ParkingSlots);
                            break;
                        }

                        else if(Type3 == 2)
                        {
                            Console.WriteLine("Enter license number:");
                            string vehicleMove = Console.ReadLine().ToUpper();
                            moveVehicleMC(vehicleMove, ParkingSlots);
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input, try again.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 4: //Sök efter fordon.
                        Console.Clear();
                        Console.WriteLine("Enter your license number:");
                        string vehicleS = Console.ReadLine().ToUpper();
                        if (vehicleS.Length <= 10 && vehicleS.Length >= 4)
                        {
                            searchVehicle(vehicleS, ParkingSlots);
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The license number is not valid, try again.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    
                    case 5: //Se tillgänglighet i parkeringshus.
                        Console.Clear();
                        checkSlots(ParkingSlots);
                        break;
                    case 6:
                        Console.Clear();
                        ShowAll(ParkingSlots);
                        break;
                    case 7:
                        Console.Clear();
                        Console.Write("Enter Password:");
                        string InputPassword = Console.ReadLine();
                        string passWord = "admin";
                        if (InputPassword == passWord)
                        {
                            Console.WriteLine("Program is shutting down");
                            retry = false;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong username or password.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    default:
                        Console.Clear();
                        retry = true;
                        break;
                }
            }
        }
        static void parkVehicleMC(int Type, string vehicle, string[] ParkingSlots)
        {
            bool IsValid = true;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Contains("EMPTY1"))
                {
                    IsValid = false;
                    ParkingSlots[y] = ParkingSlots[y].Replace("EMPTY1", "MC1;" + vehicle);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MC with license nr: {0} is parked in slot:{1}", vehicle, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else if (ParkingSlots[y].Contains("EMPTY2"))
                {
                    IsValid = false;
                    ParkingSlots[y] = ParkingSlots[y].Replace("EMPTY2", "MC2;" + vehicle);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MC with license nr: {0} is parked in slot:{1}", vehicle, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
            if (IsValid == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Parking lot is full, please try later.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        static void parkVehicle(int Type, string vehicle1, string[] ParkingSlots)
        {
            bool IsValid = true;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y] == y + "." + "EMPTY1 - EMPTY2")
                {
                    IsValid = false;
                    ParkingSlots[y] = ParkingSlots[y].Replace("EMPTY1 - EMPTY2", "CAR;" + vehicle1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Car with license nr: {0} is parked in slot:{1}", vehicle1, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
            if (IsValid == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Parking lot is full, please try later.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        static void unParkVehicleMC(int Type1, string vehicle, string[] ParkingSlots)
        {
            bool IsValid = true;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Contains(vehicle))
                {
                    IsValid = false;
                    if (ParkingSlots[y].Substring(0,16).Contains(vehicle) && ParkingSlots[y].Substring(0, 16).Contains("MC"))
                    {
                        ParkingSlots[y] = ParkingSlots[y].Replace(vehicle, "EMPTY1");
                        ParkingSlots[y] = ParkingSlots[y].Replace("MC1;", "");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("MC1 with license nr: {0}, Welcome back!", vehicle, y);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                    else if (ParkingSlots[y].Contains("MC2"))
                    {
                        ParkingSlots[y] = ParkingSlots[y].Replace(vehicle, "EMPTY2");
                        ParkingSlots[y] = ParkingSlots[y].Replace("MC2;", "");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("MC2 with license nr: {0}, Welcome back!", vehicle, y);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                }
            }
            if(IsValid == true)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No license number matched");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            Console.Clear();
            }
        }
        static void unParkVehicle(int Type1, string vehicle1, string[] ParkingSlots)
        {
            bool IsValid = true;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y] == y + "."+ "CAR;" + vehicle1)
                {
                    IsValid = false;
                    ParkingSlots[y] = ParkingSlots[y].Replace("CAR;" + vehicle1, "EMPTY1 - EMPTY2");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Car with license nr: {0}, Welcome back!", vehicle1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
            if(IsValid == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No license number matched");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        static void moveVehicle(string vehicleMove, string[] ParkingSlots)
        {
            Console.Clear();
            int sum = 0;
            for (var i = 0; i < ParkingSlots.Length; i++)
            {
                if (ParkingSlots[i] == i + "." + "CAR;" + vehicleMove && vehicleMove.Length >= 3)
                {
                    Console.WriteLine("Vehicle {0}, is parked at lot-nr: {1}", vehicleMove, i);
                    Console.WriteLine("Enter parking lotnumber to move vehicle: ");
                    int moveNr = int.Parse(Console.ReadLine());
                    if (ParkingSlots[moveNr] == moveNr + "." + "EMPTY1 - EMPTY2" && moveNr < 101)
                    {
                        ParkingSlots[i] = i + "." + "EMPTY1 - EMPTY2";
                        ParkingSlots[moveNr] = moveNr + ".CAR;" + vehicleMove;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Car is succesfully moved from lot-nr {1} to lot-nr {2}", vehicleMove, i, moveNr);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lot-nr {0} is not empty, choose another lot. (Or your number is over 100)",moveNr);
                        Console.ForegroundColor = ConsoleColor.White;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No license number matched");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }
        static void moveVehicleMC(string vehicleMove, string[] ParkingSlots)
        {
            bool isValid = false;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Contains(vehicleMove))
                {
                    Console.WriteLine("Enter parkingslotnumber to move vehicle: ");
                    int moveNr = int.Parse(Console.ReadLine());

                    isValid = true;
                    if (ParkingSlots[y].Substring(0, 16).Contains(vehicleMove) && moveNr < 101 && vehicleMove.Length >= 3)
                    {
                        ParkingSlots[y] = ParkingSlots[y].Replace(vehicleMove, "EMPTY1");
                        ParkingSlots[y] = ParkingSlots[y].Replace("MC1;", "");
                        ParkingSlots[moveNr] = ParkingSlots[moveNr].Replace("EMPTY1", "MC1;" + vehicleMove);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Car is succesfully moved from lot-nr {0} to lot-nr {1}", vehicleMove, moveNr);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        Console.Clear();
                            break;
                    }
                    else 
                    {
                        ParkingSlots[y] = ParkingSlots[y].Replace(vehicleMove, "EMPTY2");
                        ParkingSlots[y] = ParkingSlots[y].Replace("MC2;", "");
                        ParkingSlots[moveNr] = ParkingSlots[moveNr].Replace("EMPTY2", "MC2;" + vehicleMove);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Car is succesfully moved from lot-nr {0} to lot-nr {1}", vehicleMove, moveNr);
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        Console.Clear();
                            break;
                    }
                }
            }
                if (isValid == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No license number matched, or the lot is not empty.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.Clear();
                        return;
                }
            }
        static void searchVehicle(string vehicleS, string[] ParkingSlots)
        {
            bool IsValid = false;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Contains(vehicleS))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vehicle with license nr: {0}, is parked in lot:{1}", vehicleS, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.Clear();
                    IsValid = true;
                    break;
                }
            }
            if (IsValid == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No license number matched");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        static void checkSlots(string[] ParkingSlots)
        {
            int Total = 100;
            int freeSlots = 0;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Contains("EMPTY1 - EMPTY2"))                {
                    freeSlots++;
                }
            }
            Console.Clear();
            Console.WriteLine("{0} free parking lots out of {1}.", freeSlots, Total);
            Console.WriteLine();

            int bil = 0;
            int MC = 0;
            int Tom = 0;

            for(var x = 1; x < ParkingSlots.Length; x++)
            {
                if (ParkingSlots[x].Contains("EMPTY1 - EMPTY2"))
                {
                    Tom++;
                }
                else if (ParkingSlots[x].Substring(2, 3).Contains("CAR"))
                {
                    bil++;
                }
                else if (ParkingSlots[x].Contains("MC1") && ParkingSlots[x].Contains("MC2"))
                {
                    MC++;
                    MC++;
                }
                else
                {
                    MC++;
                }
            }
            Console.WriteLine(" Car: {0}\n MC: {1}", bil, MC);
            Thread.Sleep(4000);
            Console.Clear();
        }
        static void ShowAll(string[] ParkingSlots)
            {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("100% empty");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("50% empty");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0% empty");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Scroll all the way down ! (To get back to meny) ");
            Console.WriteLine();
            for (var x = 1; x < ParkingSlots.Length; x++)
            {
                if(ParkingSlots[x].Contains("EMPTY1 - EMPTY2"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ParkingSlots[x]);
                }
                else if(ParkingSlots[x].Substring(2, 4).Contains("CAR"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ParkingSlots[x]);
                }
                else if (ParkingSlots[x].Contains("MC1") && ParkingSlots[x].Contains("MC2"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ParkingSlots[x]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(ParkingSlots[x]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Scroll up !");
            Thread.Sleep(3000);
            Console.Clear();


        }
    }
}


