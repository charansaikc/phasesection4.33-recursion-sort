
using System;

namespace Phase1Section4._27
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students = new string[10];
            students[0] = "Karuna";
            students[1] = "Mono";
            students[2] = "Advaith";
            students[3] = "Sai";
            students[4] = "Nazia";
            students[5] = "Faisal";
            students[6] = "Tarun";
            students[7] = "Ganesh";
            students[8] = "Chandni";
            students[9] = "Kedar";

            int currElem = 0;
            printViaRecursion(students, currElem);
        }

        public static void printViaRecursion(string[] arr, int currElem)
        {
            Console.WriteLine(arr[currElem]);
            if (currElem < arr.Length - 1)
                printViaRecursion(arr, currElem + 1);
        }
    }
}

