

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Количество Команд
            int m = int.Parse(Console.ReadLine());  // Количество Игроков
            int count = 0;

            string[,] arr = new string[n, m]; // Пустой двухмерный массив Команд с Игроками

            Console.WriteLine("Команды и игроки по порядку: \n");
            for (int i = 0; i < n; i++) // Заполнение массива Командами и Игроками
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = " |К" + (i + 1).ToString() + "И" + (j + 1).ToString() + "|"; // Игроки имеют тип Стринг и содержат номер своей команды и свой номер
                    Console.Write(arr[i, j]); // Вывод на экран
                }
                Console.WriteLine();

                for (int l = 0; l < m; l++) // Для сохрания разметки поля
                {
                    Console.Write("-------");
                }
                Console.WriteLine();

            }
            Console.WriteLine();


            string[,] newArr = new string[m, n]; // Создание нового массива с новой расстановкой игроков

            Console.WriteLine("Все игроки разные в рядках: \n");
            for (int i = 0; i < newArr.GetLength(0); i++) // Разворот массива на 90 градусов. Этим достигается размещение игроков разных команд в ряды
            {
                for (int j = 0; j < newArr.GetLength(1); j++)
                {
                    newArr[i, j] = arr[j, i];
                    Console.Write(newArr[i, j]);
                }
                Console.WriteLine();


                for (int l = 0; l < n; l++) // Вывод на экран с учетом первого требования задачи
                {
                    Console.Write("-------");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Расстановка спортсменов: \n");



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
                    for (int j = 0; j < newArr.GetLength(1); j++)
                    {
                        Console.Write(newArr[i, j]);
                    }                  
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

            Console.WriteLine("-------------------");
            Console.WriteLine();

        }

    }
}
