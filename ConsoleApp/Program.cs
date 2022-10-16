using System;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {

        //ConsoleKey consoleKey = Console.ReadKey().Key;
        //switch (consoleKey)

        int[] myArray = { 1123, 21, 345, 123, 51, 12, 634, 41, 123, 85, 12, 1123 };

        // Console.WriteLine(myArray.Where(i => i % 2 > 0).Min()); //минимальное, нечетное число

        // создание нового массива с уникальными элементами от другого массива
        // т.е из двух одинаковых эл-ов перемещается один
        // OrderBy(i => i) - сортировка массива по возрастанию
        // OrderByDescending(i => i) - сортировка массива по убыванию
        //int[] secondArray = myArray.Distinct().OrderBy(i => i).ToArray();
        //Program.printArray(secondArray);

        // сортировка массива по возрастанию с помощью статического метода Sort()
        Array.Sort(myArray);
        //поиск элемента с начала массива меньше 70, первый найденый элемент будет помешен в переменную
        int result = Array.Find(myArray, i => i < 70);
        //поиск элемента с конца массива меньше 70, первый найденый элемент будет помешен в переменную
        int resulttwo = Array.FindLast(myArray, i => i < 70); 
    }

    public static void printArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
 