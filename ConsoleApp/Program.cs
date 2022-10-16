using System;

class Program
{

    static void Main(string[] args)
    {

        //ConsoleKey consoleKey = Console.ReadKey().Key;
        //switch (consoleKey)

        int[] myArray = { 1123, 21, 345, 123, 51 };

        Program.printArray(myArray);
        
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

    public static void printArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
 