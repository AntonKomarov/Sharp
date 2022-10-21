using System;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {

        //ConsoleKey consoleKey = Console.ReadKey().Key;
        //switch (consoleKey)

        int[] myArray = { 1123, 21, 345, 41, 123, 51, 12, 634, 41, 123, 85, 12, 1123 };

        // Console.WriteLine(myArray.Where(i => i % 2 > 0).Min()); //минимальное, нечетное число

        // создание нового массива с уникальными элементами от другого массива
        // т.е из двух одинаковых эл-ов перемещается один
        // OrderBy(i => i) - сортировка массива по возрастанию
        // OrderByDescending(i => i) - сортировка массива по убыванию
        //int[] secondArray = myArray.Distinct().OrderBy(i => i).ToArray();
        

        // сортировка массива по возрастанию с помощью статического метода Sort()
        //Array.Sort(myArray);
        //поиск элемента с начала массива меньше 70, первый найденый элемент будет помещен в переменную
        int result = Array.Find(myArray, i => i < 70);
        //поиск элемента с конца массива меньше 70, первый найденый элемент будет помещен в переменную
        int resultTwo = Array.FindLast(myArray, i => i < 70);
        //поиск элементов с начала массива меньше 70, найденые элементы будут помещены в массив
        int[] resultTree = Array.FindAll(myArray, i => i < 70);
        //поиск элемента с начала массива равного 41, индекс первого найденого элемента будет помещен в переменную
        //если элемета не существует в переменную помещается значение -1
        int index = Array.FindIndex(myArray, i => i == 41);
        //поиск элемента с конца массива равного 41, индекс первого найденого элемента будет помещен в переменную
        int indexLast = Array.FindLastIndex(myArray, i => i == 41);
        //элементы будут идти в обратном порядке
        //Array.Reverse(myArray);

        //методы из библиотеки Linq - более поздняя версия и более вариативная
        int[] arrayLinq = myArray.Where(i => i < 70).ToArray();
        //первое число меньше 70
        int element = myArray.Where(i => i < 70).First();
        //если элемент не найден получаем exeption (System.InvalidOperationExeption)
        int elementExeption = myArray.Where(i => i == 0).First();
        //если элемент не найден получаем деволтное значение для того эл-та данных которое мы ищем
        int elementDefault = myArray.Where(i => i == 0).FirstOrDefault();


        // объявление и выделение памяти многомерного массива
        int[,] myMatrix = new int[3, 5];
        
        Program.printArray(myArray);

        //ступенчатые(зубчатые) массивы
        int[][] myTeethArray = new int[5][];

        int[] myArray1 = new int[5];
        int[] myArray2 = new int[2];
        int[] myArray3 = new int[7];
        int[] myArray4 = new int[1];
        int[] myArray5 = new int[9];

        Random random = new Random();

        for (int i = 0; i < myTeethArray.Length; i++)
        {
            for (int j = 0; j < myTeethArray[i].Length; j++)
            {
                
            }

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
 