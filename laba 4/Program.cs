using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { //task 1
                int[] a = new int[8];
                Random rand = new Random();
                int min = int.MaxValue;
                Console.WriteLine("Вихiдний масив:");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = rand.Next(-10, 20);
                    Console.WriteLine($"a{i}={a[i]}");
                }

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0 && a[i] % 2 != 0)
                    {
                        Console.WriteLine("Непарне число:" + a[i]);
                        if (a[i] < min)
                        {
                            min = a[i];
                        }
                    }
                }


                if (min != int.MaxValue)
                {
                    Console.WriteLine("Мiнiмальне непарне додатнє значення: " + min);
                }
            }

                { //task 2
                Console.WriteLine("Довжина масиву:");
                int a = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[a];
                Random rand = new Random();
                int minIndex = 0;
                int maxIndex = 0;
                int min = array[0];
                int max = array[0];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-11, 20);
                    Console.WriteLine("Рандом:" + array[i]);
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        minIndex = i;
                        Console.WriteLine("Мiнiмальний елемент:" + min);

                    }
                    if (array[i] > max)
                    {
                        max = array[i];
                        maxIndex = i;
                        Console.WriteLine("Максимальний елемент:" + max);

                    }
                }

                int sum = 0;
                if (minIndex < maxIndex)
                {
                    for (int i = minIndex; i <= maxIndex; i++)
                        sum += array[i];
                }
                else
                {
                    for (int i = maxIndex; i <= minIndex; i++)
                        sum += array[i];
                }

                Console.WriteLine("Сума чисел мiж мiнiмальним i максимальним: " + sum);
            }
        }
    }
    }

