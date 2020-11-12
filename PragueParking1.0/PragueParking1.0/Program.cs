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

            //**Lösenord för att avsluta programmet: admin 

            //Programmet använder Threading, så efter avslutad metod/text, tar det mellan 3-5 sekunder innan
            //programmet går vidare alt återgår till huvudmenyn, detta för att användaren aldrig ska fastna.

            ////////////////////////////////////////////////////////////////////////
            


            //Skapar en lista med 100 platser.

            string[] ParkingSlots = new string[101]; { };
            for (var i = 1; i < 101; i++)
            {
                ParkingSlots[i] = "EMPTY1 ; EMPTY2";
            }

            bool retry = true;
            while (retry)   //Om användaren ger ett felaktigt val, börjar programmet om.
            {
                //Användare-meny.            Console.Clear();
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
                string input = Console.ReadLine();int userChoice;Int32.TryParse(input, out userChoice);

                //Användarens val går till switchEn.
                switch (userChoice)
                {
                    case 1: //Parkera Fordon.
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        string typ = Console.ReadLine().ToUpper();int Type;Int32.TryParse(typ, out Type);

                        if (Type == 2)//Parkera Bil, kontrollera att regnummer inte redan finns i systemet. 
                        {
                            Console.Clear();
                            Console.WriteLine("Enter your 10 letter license plate number:");
                            string vehicle = Console.ReadLine().ToUpper();
                            int sum = 0;
                            for(var i=1; i < ParkingSlots.Length; i++)
                            {if (ParkingSlots[i].Contains(vehicle)){sum++;}}

                            if (vehicle.Length == 10 && sum == 0)
                            {
                                parkVehicleMC(Type, vehicle, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The license plate number must be 10 letters\n(Or the platenumber already exist), try again.");
                                Thread.Sleep(4000);
                                Console.Clear();
                                break;
                            }
                        }
                        else if (Type == 1) //Parkera MC
                        {
                            Console.Clear();
                            Console.WriteLine("Enter your 10 letter license plate number:");
                            string vehicle1 = Console.ReadLine().ToUpper();
                            int sum = 0;
                            for (var i = 1; i < ParkingSlots.Length; i++)
                            {
                                if (ParkingSlots[i].Contains(vehicle1))
                                {
                                    sum++;
                                }
                            }
                            if (vehicle1.Length == 10 && sum == 0)
                            {
                                parkVehicle(Type, vehicle1, ParkingSlots);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The license plate number must be 10 letters\n(Or the platenumber already exist), try again.");
                                Thread.Sleep(4000);
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
        
                    case 2://Avparkera fordon.
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        string typ1 = Console.ReadLine().ToUpper();int Type1;Int32.TryParse(typ1, out Type1);

                        if (Type1 == 2)//Avparkera bil.
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
                        else if (Type1 == 1) //Avparkera MC.
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
                    case 3://Flytta Bil:
                    
                        Console.Clear();
                        Console.WriteLine("Enter: 1. Car | 2. MC");
                        string typ2 = Console.ReadLine().ToUpper(); int Type3; Int32.TryParse(typ2, out Type3);

                        if(Type3 == 1)
                        {
                            Console.WriteLine("Enter license plate number:");
                            string vehicleMove = Console.ReadLine().ToUpper();
                            moveVehicle(vehicleMove, ParkingSlots);
                            break;
                        }

                        else if(Type3 == 2)
                        {
                            Console.WriteLine("Enter license plate number:");
                            string vehicleMove = Console.ReadLine().ToUpper();
                            moveVehicleMC(vehicleMove, ParkingSlots);
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input, try again.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 4: //Sök efter fordon.
                        Console.Clear();
                        Console.WriteLine("Enter your 10 letter license plate number:");
                        string vehicleS = Console.ReadLine().ToUpper();
                        if (vehicleS.Length == 10)
                        {
                            searchVehicle(vehicleS, ParkingSlots);
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
                            Console.WriteLine("Wrong username or password.");
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
        //Parkerar/lägger till ett fordon********************************
        static void parkVehicleMC(int Type, string vehicle, string[] ParkingSlots)
        {
            int sum = 0;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Substring(0, 6) == "EMPTY1")
                {
                    sum++;
                    ParkingSlots[y] = ParkingSlots[y].Replace("EMPTY1", vehicle);
                    Console.Clear();
                    Console.WriteLine("MC with license nr: {0} is parked in slot:{1}", vehicle, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else if (ParkingSlots[y].Length > 13 && ParkingSlots[y].Substring(13, 6) == "EMPTY2")
                {
                    sum++;
                    ParkingSlots[y] = ParkingSlots[y].Replace("EMPTY2", vehicle);
                    Console.Clear();
                    Console.WriteLine("MC with license nr: {0} is parked in slot:{1}", vehicle, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
            if (sum == 0){Console.WriteLine("Parking lot is full, please try later.");}
        }
        static void parkVehicle(int Type, string vehicle1, string[] ParkingSlots)
        {
            int sum = 0;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y] == "EMPTY1 ; EMPTY2")
                {
                    sum++;
                    ParkingSlots[y] = ParkingSlots[y].Replace("EMPTY1 ; EMPTY2", vehicle1);
                    Console.Clear();
                    Console.WriteLine("Car with license nr: {0} is parked in slot:{1}", vehicle1, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
            if (sum == 0){Console.WriteLine("Parking lot is full, please try later.");}
        }
        //Hämtar ut ett fordon från parkeringsplatsen********************************
        static void unParkVehicleMC(int Type1, string vehicle, string[] ParkingSlots)
        {
            int sum = 0;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Contains(vehicle))
                {
                    sum++;
                    if (ParkingSlots[y].Substring(0, 10) == vehicle)
                    {
                        ParkingSlots[y] = ParkingSlots[y].Replace(vehicle, "EMPTY1");
                        Console.Clear();
                        Console.WriteLine("MC with license nr: {0}, Welcome back!", vehicle, y);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                    else if (ParkingSlots[y].Length > 13 && ParkingSlots[y].Substring(9, 10) == vehicle)
                    {
                        ParkingSlots[y] = ParkingSlots[y].Replace(vehicle, "EMPTY2");
                        Console.Clear();
                        Console.WriteLine("MC with license nr: {0}, Welcome back!", vehicle, y);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                    else if (ParkingSlots[y].Length > 13 && ParkingSlots[y].Substring(13, 10) == vehicle)
                    {
                        ParkingSlots[y] = ParkingSlots[y].Replace(vehicle, "EMPTY2");
                        Console.Clear();
                        Console.WriteLine("MC with license nr: {0}, Welcome back!", vehicle, y);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                    else{}
                    }
                }
                if(sum == 0)
                {
                Console.Clear();
                Console.WriteLine("No license number matched");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        static void unParkVehicle(int Type1, string vehicle1, string[] ParkingSlots)
        {
            int sum = 0;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y] == vehicle1)
                {
                    sum ++;
                    ParkingSlots[y] = ParkingSlots[y].Replace(vehicle1, "EMPTY1 ; EMPTY2");
                    Console.WriteLine("Car with license nr: {0}, Welcome back!", vehicle1);
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
            if(sum == 0)
            {
                Console.Clear();
                Console.WriteLine("No license plate matched");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        //Flyttar på ett fordon.
        static void moveVehicle(string vehicleMove, string[] ParkingSlots)
        {
            Console.Clear();
            int sum = 0;
            for (var i = 0; i < ParkingSlots.Length; i++)
            {
                if (ParkingSlots[i] == vehicleMove)
                {
                    Console.Clear();
                    Console.WriteLine("Vehicle {0}, is parked at lot-nr: {1}", vehicleMove, i);
                    Console.WriteLine("Enter witch parkingslotnumber to move vehicle: ");
                    int moveNr = int.Parse(Console.ReadLine());
                    if (ParkingSlots[moveNr] == "EMPTY1 ; EMPTY2" && moveNr < 101)
                    {
                        ParkingSlots[i] = "EMPTY1 ; EMPTY2";
                        ParkingSlots[moveNr] = vehicleMove;
                        Console.Clear();
                        Console.WriteLine("Car is succesfully moved from lot-nr {1} to lot-nr {2}", vehicleMove, i, moveNr);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lot-nr {0} is not empty, choose another lot. (Or your number is over 100)",moveNr);
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
                    Console.Clear();
                    Console.WriteLine("No license plate matched");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }
        static void moveVehicleMC(string vehicleMove, string[] ParkingSlots)
        {
            int sum = 0;
                for (var y = 1; y < ParkingSlots.Length; y++)
                {
                    if (ParkingSlots[y].Contains(vehicleMove))
                    {
                        if (ParkingSlots[y].Substring(0, 10) == vehicleMove)
                        {
                            ParkingSlots[y] = ParkingSlots[y].Replace(vehicleMove, "EMPTY1");
                            Console.Clear();
                            Console.WriteLine("Vehicle {0}, is parked at lot-nr: {1}", vehicleMove, y);
                            break;
                        }
                        else if (ParkingSlots[y].Length > 13 && ParkingSlots[y].Substring(9, 10) == vehicleMove)
                        {
                            ParkingSlots[y] = ParkingSlots[y].Replace(vehicleMove, "EMPTY2");
                            Console.Clear();
                            Console.WriteLine("Vehicle {0}, is parked at lot-nr: {1}!", vehicleMove, y);
                            break;
                        }
                        else if (ParkingSlots[y].Length > 13 && ParkingSlots[y].Substring(13, 10) == vehicleMove)
                        {
                            ParkingSlots[y] = ParkingSlots[y].Replace(vehicleMove, "EMPTY2");
                            Console.Clear();
                            Console.WriteLine("Vehicle {0}, is parked at lot-nr: {1}!", vehicleMove, y);
                            break;
                        }
                    }
                    else{sum++;}
                }
                     if (sum != 0)
                     {
                        Console.Clear();
                        Console.WriteLine("No license number matched");
                        Thread.Sleep(3000);
                        Console.Clear();
                        return;
                     }

            Console.WriteLine("Enter parkingslotnumber to move vehicle: ");
                int moveNr = int.Parse(Console.ReadLine());

                    if (ParkingSlots[moveNr].Substring(0, 6) == "EMPTY1" && moveNr < 101)
                    {
                        ParkingSlots[moveNr] = ParkingSlots[moveNr].Replace("EMPTY1", vehicleMove);
                        Console.Clear();
                        Console.WriteLine("Car is succesfully moved from lot-nr {0} to lot-nr {1}", vehicleMove, moveNr);
                        Thread.Sleep(3000);
                        Console.Clear();
                        
                    }
                    else if (ParkingSlots[moveNr].Length > 13 && ParkingSlots[moveNr].Substring(9, 6) == "EMPTY2" && moveNr < 101)
                    {
                        ParkingSlots[moveNr] = ParkingSlots[moveNr].Replace("EMPTY2", vehicleMove);
                        Console.Clear();
                        Console.WriteLine("Car is succesfully moved from lot-nr {0} to lot-nr {1}", vehicleMove, moveNr);
                        Thread.Sleep(3000);
                        Console.Clear();
                        
                    }
                    else if (ParkingSlots[moveNr].Length > 13 && ParkingSlots[moveNr].Substring(13, 6) == "EMPTY2" && moveNr < 101)
                    {
                        ParkingSlots[moveNr] = ParkingSlots[moveNr].Replace("EMPTY2", vehicleMove);
                        Console.Clear();
                        Console.WriteLine("Car is succesfully moved from lot-nr {0} to lot-nr {1}", vehicleMove, moveNr);
                        Thread.Sleep(3000);
                        Console.Clear();
                        
                    }
                    else
                    {
                        Console.WriteLine("Lot-nr {0} is not empty, choose another lot.(Or your number is over 100)", vehicleMove);
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
            }
        //Söker efter valt registeringsnummer. ********************************
        static void searchVehicle(string vehicleS, string[] ParkingSlots)
        {
            int sum = 0;
            for (var y = 1; y < ParkingSlots.Length; y++)
            {
                if (ParkingSlots[y].Contains(vehicleS))
                {
                    Console.Clear();
                    Console.WriteLine("Vehicle with license nr: {0}, is parked in lot:{1}", vehicleS, y);
                    Thread.Sleep(3000);
                    Console.Clear();
                    sum++;
                    break;
                }
            }
               if(sum == 0)
                {
                    Console.Clear();
                    Console.WriteLine("No license number matched");
                    Thread.Sleep(3000);
                    Console.Clear();
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
            }
            Console.Clear();
            Console.WriteLine("{0} free parkingslots out of {1}.", freeSlots, Total);
            Thread.Sleep(3000);
            Console.Clear();
        }
        static void ShowAll(string[] ParkingSlots)
            {
            Console.WriteLine("Scroll all the way down ! (To get back to meny) ");
            Console.WriteLine();
            for (var x = 1; x < ParkingSlots.Length; x++)
            {
                if(ParkingSlots[x].Contains("EMPTY1 ; EMPTY2"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ParkingSlots[x]);
                }
                else if(ParkingSlots[x].Length < 11)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ParkingSlots[x]);
                }
                else if (ParkingSlots[x].Length > 19)
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


