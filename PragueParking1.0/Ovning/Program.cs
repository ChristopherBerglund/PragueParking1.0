using System;

namespace haha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[101];
            //char separator = ';';
            for (var i = 1; i < arr.Length; i++)
            {
                arr[i] = "EMPTY1 ; EMPTY2";
            }

            for (var y = 1; y < arr.Length; y++)
            {
                if (arr[y].Substring(0, 6) == "EMPTY1")
                {
                    arr[y] = arr[y].Replace("EMPTY1", "Vehicle");
                    break;
                }
                else if (arr[y].Substring(10, 6) == "EMPTY2")
                {
                    arr[y] = arr[y].Replace("EMPTY2", "Vehicle");
                    break;
                }

            }
            for (var y = 1; y < arr.Length; y++)
            {
                if (arr[y].Substring(4, 6) == "EMPTY1")
                {
                    arr[y] = arr[y].Replace("EMPTY1", "Vehicle1");
                    break;
                }
                else if (arr[y].Substring(10, 6) == "EMPTY2")
                {
                    arr[y] = arr[y].Replace("EMPTY2", "Vehicle1");
                    break;
                }

            }
            for (var x = 1; x < arr.Length; x++)
            {
                Console.WriteLine(arr[x]);
            }

            int index = Array.IndexOf(arr, "vehicle1");
            index += 2;
            Console.WriteLine("{0}", index);







            //Console.WriteLine(arr[x].Substring(0, 6));
            //Console.WriteLine(arr[x].Substring(9));

        }
    }
}