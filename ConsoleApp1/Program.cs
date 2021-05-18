using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите размерность первой матрицы");
            byte razmer = Convert.ToByte(Console.ReadLine());
            int[,] matrixone = new int[razmer, razmer];
            Console.Write("Введите размерность второй матрицы");
            razmer = Convert.ToByte(Console.ReadLine());
            int[,] matrixtwo = new int[razmer, razmer];
            Console.WriteLine("Какой ввод вы хотите использовать?\ntrue - ручной,false - рандомные числа");
            bool vybor = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();
            if (vybor == true)
            {
                for (int a = 0;a < razmer;a++)
                {
                    for (int b = 0; b < razmer; b++)
                    {
                        Console.WriteLine($"Введите число для первой матрицы [{a},{b}]");
                        int number = Convert.ToInt32(Console.ReadLine());
                        matrixone[a, b] = number;

                        Console.WriteLine($"Введите число для второй матрицы [{a},{b}]");
                        number = Convert.ToInt32(Console.ReadLine());
                        matrixone[a, b] = number;
                    }
                }
            }
            else
            {
                for (int a = 0; a < razmer; a++)
                {
                    for (int b = 0; b < razmer; b++)
                    {   
                        int number = rand.Next(1,20);
                        matrixone[a, b] = number;
                        number = rand.Next(1, 20);
                        matrixtwo[a, b] = number;
                    }
                }
            }
            Console.Write("Выберите операцию для работы с созданными матрицами: 1 сложение, 2 умножение на число, 3 умножение матриц, 4 транспонирование, 5 возведение матрицы в степень");
            byte operation = Convert.ToByte(Console.ReadLine());
            //проверка гита 1
        }
        
    }
    
    
}