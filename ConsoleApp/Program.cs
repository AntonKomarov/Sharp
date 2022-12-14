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

        /////////////////////////////////индексация 
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
        //int elementExeption = myArray.Where(i => i == 0).First();
        //если элемент не найден получаем дефолтное значение для того эл-та данных которое мы ищем
        int elementDefault = myArray.Where(i => i == 0).FirstOrDefault();


        ////////////////////////////////////объявление и выделение памяти многомерного массива
        int[,] myMatrix = new int[3, 5];   

        ////////////////////////////////////ступенчатые(зубчатые) массивы
        int[][] myTeethArray = new int[5][];

        myTeethArray[0] = new int[5];
        myTeethArray[1] = new int[2];
        myTeethArray[2] = new int[7];
        myTeethArray[3] = new int[1];
        myTeethArray[4] = new int[9];

        Random random = new Random();

        for (int i = 0; i < myTeethArray.Length; i++)
        {
            for (int j = 0; j < myTeethArray[i].Length; j++)
            {
                myTeethArray[i][j] = random.Next(100);
            }
        }


        for (int i = 0; i < myTeethArray.Length; i++)
        {
            for (int j = 0; j < myTeethArray[i].Length; j++)
            {
                Console.Write(myTeethArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        //////////////////////////////////////трёхмерные массивы
        int[,,] myThirdArray =
        {
            {
                {12,23,46},
                {32,74,12}
            },

            {
                {31,67,31},
                {42,22,53}
            },

            {
                {34,52,12},
                {11,53,84}
            }
        };

        for (int x = 0; x < myThirdArray.GetLength(0); x++)
        {
            for (int y = 0; y < myThirdArray.GetLength(1); y++)
            {
                for (int z = 0; z < myThirdArray.GetLength(2); z++)
                {
                    Console.Write(myThirdArray[x, y, z] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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
 