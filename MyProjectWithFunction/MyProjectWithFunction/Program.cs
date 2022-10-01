using System;

namespace ConsoleApplication1
{
    class Program
    {
        static string[,] FillArray(int n, int m) // Заполнение массива Командами и Игроками
        {
            string[,] newArr = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Игроки имеют тип Стринг и содержат номер своей команды и свой номер
                    newArr[i, j] = " |К" + (i + 1).ToString() + "И" + (j + 1).ToString() + "|";
                }
            }

            return newArr;
        }
        static string[,] FillAndTurnArray(string[,] old_arr)
        {
            int m = old_arr.GetUpperBound(1) + 1;
            int n = old_arr.GetUpperBound(0) + 1;

            string[,] new_arr = new string[m, n]; // Создание нового массива с новой расстановкой игроков

            for (int i = 0; i < m; i++) // Разворот массива на 90 градусов. Этим достигается размещение игроков разных команд в ряды
            {
                for (int j = 0; j < n; j++)
                {
                    new_arr[i, j] = old_arr[j, i];
                }
            }

            return new_arr;
        }
        static void ShiftElemsOfArray(ref string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++) // Сдвиг элементов массива для того чтобы игроки с одной команды не стояли друг под другом.
            {
                if (i % 2 == 0 && i % 4 != 0)
                {
                    string tmp = arr[i, 0];

                    for (int j = 1; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j]);
                    }
                    Console.Write(tmp);
                }

                if (i == 1)
                {
                    //string tmp = arr[i, arr.GetLength(1) - 1];

                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j]);
                    }
                    //Console.Write(tmp);


                }
                else if (i % 3 == 0)
                {
                    string tmp = arr[i, 0];
                    string tmp1 = arr[i, 1];


                    for (int j = 2; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j]);
                    }
                    Console.Write(tmp);
                    Console.Write(tmp1);
                }
                else if (i % 4 == 0 && i > 2)
                {
                    string tmp = arr[i, 0];
                    string tmp1 = arr[i, 1];
                    string tmp2 = arr[i, 2];

                    for (int j = 3; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j]);
                    }
                    Console.Write(tmp);
                    Console.Write(tmp1);
                    Console.Write(tmp2);
                }
                else if (i % 5 == 0)
                {
                    string tmp = arr[i, arr.GetLength(1) - 1];

                    for (int j = 0; j < arr.GetLength(1) - 1; j++)
                    {
                        Console.Write(arr[i, j]);
                    }
                    Console.Write(tmp);

                }
            }
        }
        static void PrintArray(string[,] arr)
        {
            int n = arr.GetUpperBound(0) + 1;
            int m = arr.GetUpperBound(1) + 1;

            for (int i = 0; i < n; i++) // Заполнение массива Командами и Игроками
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j]); // Вывод на экран
                }
                Console.WriteLine();

                for (int l = 0; l < m; l++) // Для создания разметки поля
                {
                    Console.Write("-------");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Количество Команд
            int m = int.Parse(Console.ReadLine()); ; // Количество Игроков
            int count = 0;

            string[,] arr = FillArray(n, m); // 

            Console.WriteLine("Команды и игроки по порядку: \n");
            PrintArray(arr);

            string[,] newArr = FillAndTurnArray(arr); // Создание нового массива с новой расстановкой игроков
            Console.WriteLine("Все игроки разные в рядках: \n");
            PrintArray(newArr);

            Console.WriteLine("Игроки одной команды в колонках не повторяются повторно: \n");

            for (int i = 0; i < newArr.GetLength(0); i++) // Сдвиг элементов массива для того чтобы игроки с одной команды не стояли друг под другом.
            {
                if (i % 2 == 0 && i % 4 != 0)
                {
                    string tmp = newArr[i, 0];

                    for (int j = 1; j < newArr.GetLength(1); j++)
                    {
                        Console.Write(newArr[i, j]);
                    }
                    Console.Write(tmp);
                }

                if (i == 1)
                {
                    //string tmp = newArr[i, newArr.GetLength(1) - 1];

                    for (int j = 0; j < newArr.GetLength(1); j++)
                    {
                        Console.Write(newArr[i, j]);
                    }
                    //Console.Write(tmp);


                }
                else if (i % 3 == 0)
                {
                    string tmp = newArr[i, 0];
                    string tmp1 = newArr[i, 1];


                    for (int j = 2; j < newArr.GetLength(1); j++)
                    {
                        Console.Write(newArr[i, j]);
                    }
                    Console.Write(tmp);
                    Console.Write(tmp1);
                }
                else if (i % 4 == 0 && i > 2)
                {
                    string tmp = newArr[i, 0];
                    string tmp1 = newArr[i, 1];
                    string tmp2 = newArr[i, 2];

                    for (int j = 3; j < newArr.GetLength(1); j++)
                    {
                        Console.Write(newArr[i, j]);
                    }
                    Console.Write(tmp);
                    Console.Write(tmp1);
                    Console.Write(tmp2);
                }
                else if (i % 5 == 0)
                {
                    string tmp = newArr[i, newArr.GetLength(1) - 1];



                    for (int j = 0; j < newArr.GetLength(1) - 1; j++)
                    {
                        Console.Write(newArr[i, j]);
                    }
                    Console.Write(tmp);

                }
                Console.WriteLine();

                for (int l = 0; l < n; l++) // Вывод на экран с учетом второго требования задачи
                {
                    Console.Write("-------");
                }

                Console.WriteLine();
            }
        }
    }
}
