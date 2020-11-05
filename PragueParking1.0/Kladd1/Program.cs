using System;
using System.Collections.Generic;

namespace ArrayApplication
{
    class program
    {
        static void parkVehicle()
        {

            string[] ParkingSlots = new string[101];
            { };

            for (var i = 1; i < 101; i++)
            {
                ParkingSlots[i] = i + ".empty";
            }

            Console.WriteLine("1. Park a vehicle");
            Console.WriteLine();
             
            bool isInputValid = true;

            while (isInputValid)
            {
                Console.WriteLine("Enter your licence plate number (10 letters):");
                string vehicle = Console.ReadLine().ToUpper();
                int length = vehicle.Length;
                if (length == 10)
                {
                    for (var i = 0; i < ParkingSlots.Length; i++)
                    {
                        if (ParkingSlots[i] == i + ".empty")
                        {
                            ParkingSlots[i] = i + "." + vehicle;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Your licence plat is: {0}, continue to parkinglot-nr: {1}", vehicle, i);
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                           
                        
                            break;
                        }
                        isInputValid = false;
                    }
                }
                else if (length > 10)
                {
                    Console.WriteLine("Licence plate is to long, try again");
                    
                }
                else if (length < 10)
                {
                    Console.WriteLine("Licence plat is to short, try again");
                    
                }
            }

            //Array.Sort(ParkingSlots);
            //    var target = Array.BinarySearch(ParkingSlots, vehicle);



            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //Skriver ut hela parkeringshuset.

            for (var y = 0; y < ParkingSlots.Length; y++)
            {
                Console.WriteLine(ParkingSlots[y]);
            }

        }
    



                static void UnParkVehicle()
                {
                    Console.WriteLine("Unpark a vehicle");
                }
                static void moveVehicle()
                {
                    Console.WriteLine("Move vehicle");
                }
                static void searchVehicle()
                {
                    Console.WriteLine("Search for a vehicle");
                }
                static void checkSlots()
                {
                    Console.WriteLine("Check for free slots");
                }



                static void Main(string[] args)
                {
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
                int userChoice = int.Parse(Console.ReadLine());

                        switch (userChoice)
                        {
                            case 1:
                                parkVehicle();
                                retry = true;
                                break;
                            case 2:
                                UnParkVehicle();
                                retry = true;
                                break;
                            case 3:
                                moveVehicle();
                                retry = true;
                                break;
                            case 4:
                                searchVehicle();
                                retry = true;
                                break;
                            case 5:
                                checkSlots();
                                retry = true;
                                break;
                                case 6:
                                Console.WriteLine("Program is shutting down"); 
                                    retry = false;
                                    break;

                                default:
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
            }
        }
    



        
    









/*--------  ARRAY ------------*/

//int[] n = new int[10]; /* n is an array of 10 integers */
//int i, j;

///* initialize elements of array n */
//for (i = 0; i < 10; i++)
//{
//    n[i] = i + 100;
//}

///* output each array element's value */
//for (j = 0; j < 10; j++)
//{
//    Console.WriteLine("Element[{0}] = {1}", j, n[j]);
//}
//Console.ReadKey();

//Element[0] = 100
//Element[1] = 101
//Element[2] = 102
//Element[3] = 103
//Element[4] = 104
//Element[5] = 105
//Element[6] = 106
//Element[7] = 107
//Element[8] = 108
//Element[9] = 109
/* ------------------------------------------------*/