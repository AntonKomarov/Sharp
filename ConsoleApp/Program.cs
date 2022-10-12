using System;

class Program
{

    static void Main(string[] args)
    {

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
 