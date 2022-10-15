using System;

class Program
{

    static void Main(string[] args)
    {

        //ConsoleKey consoleKey = Console.ReadKey().Key;
        //switch (consoleKey)

        int[] myArray = { 1123, 21, 345, 123, 51 };
        for(int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
        
        bool CPUTemperature = true;
        bool CPUFan = true;

        if (CPUTemperature || CPUFan)
        {
            Console.WriteLine("Everithing okay");
        }
        else
        {
            Console.WriteLine("CPU temperature critical!");
        }
    }
}
 