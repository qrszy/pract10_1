using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace parct10._1
{
    internal class Program
    {
        static void mas (int[,] mas)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                    Console.Write($"{mas[i, j],3}");
                    
                }
                Console.WriteLine();
            }

        }
        static void Main (string[] args)
        {

            //Var7

            try
            {
                /* Console.WriteLine("Введите кол-во строк");
                 int s = int.Parse(Console.ReadLine());
                 Console.WriteLine("Введите ко-во стобцов");
                 int st = int.Parse(Console.ReadLine());
                 double sum = 0, k = 0, su = 0, kk = 0, g = 0;
                 int[,] mas = new int[s, st];
                 for (int i = 0; i < mas.GetLength(0); i++)
                 {
                     for (int j = 0; j < mas.GetLength(1); j++)
                     {
                         mas[i, j] = rnd.Next(0, 100);
                         Console.Write($"{mas[i, j],3}");
                         if (j == 1 && mas[i, j] > 15)
                         {
                             g++;
                         }
                         if (i == 4 && mas[i, j] % 2 == 1)
                         {
                             sum += mas[i, j];
                             k++;
                         }
                         if (j == 3 && mas[i, j] % 4 == 0)
                         {
                             su += mas[i, j];
                             kk++;
                         }
                     }
                     Console.WriteLine();
                 }
                 Console.WriteLine($"Кол-во ненулевых элементов,боьших 15-ти равно={g}");
                 Console.WriteLine($"Среднее арифметическое нечётных элементов пятой строки={sum / k}");
                 Console.WriteLine($"Среднее арифметическое элементов четвёртого,кратных четырем={su / kk}");*/





                //18

                /*Console.WriteLine("Введите кол-во строк");
                int s = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите ко-во стобцов");
                int st = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите k");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите k1");
                int k1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите k2");
                    int k2 = int.Parse(Console.ReadLine());
                    double sum=0,k=0,kk=0;
                int[,] maas = new int[s, st];
                mas(maas);
                Console.WriteLine();
                for (int i = 0; i < maas.GetLength(0); i++)
                {
                    k = 0; sum=0;
                    for (int j = 0; j < maas.GetLength(1); j++)
                    {
                        if (maas[i, j] > 0 && maas[i, j] % l == 0)
                        {
                            k++;
                        }
                        if (j == 0)kk++;
                        if(k1<j&& k2>j)sum+=maas[i,j];
                    }
                    Console.WriteLine($"Кол-во положительных эементов,кратных {l} ={k}");
                    Console.WriteLine($"сумма элементов с {k1} до {k2} ={sum}");
                }*/


                //19

                Console.WriteLine("Введите кол-во строк");
                int s = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите ко-во стобцов");
                int st = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите a");
                int k1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
                int k2 = int.Parse(Console.ReadLine());
                double sum = 0, k = 0, kk = 0;
                int[,] maas = new int[s, st];
                mas(maas);
                Console.WriteLine();
                for (int i = 0; i < maas.GetLength(0); i++)
                {
                    k = 0;
                    sum = 0;
                    for (int j = 0; j < maas.GetLength(1); j++)
                    {
                        if (maas[i, j]%k1==0 || maas[i, j] % k2 == 0)
                        {
                            k++;
                        }
                        if (j == 0)
                            kk++;
                        if (k1 < j && k2 > j)
                            sum += maas[i, j];
                    }

                    Console.WriteLine($"сумма элементов с {k1} до {k2} ={sum}");
                }


            }
            catch { Console.WriteLine("Некорректный ввод"); }

            Console.ReadKey();
        }
    }
}
