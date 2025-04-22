using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr16_2_v3_voroshilov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размерность массива");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] startArr = new double[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Введите {i + 1} значение");
                    startArr[i] = Convert.ToDouble(Console.ReadLine());
                }

                Dictionary<double, int> dict = new Dictionary<double, int>();

                Console.WriteLine("----------");

                for (int i = 0; i < n; i++)
                {
                    if (!dict.ContainsKey(startArr[i]))
                    {
                        int count = startArr.Count(p => p == startArr[i]);
                        Console.WriteLine($"{startArr[i]} - {count}");
                        dict.Add(startArr[i], count);
                    }
                }

                Console.WriteLine("----------");

                foreach (var d in dict)
                {
                    Console.WriteLine($"{d.Key * d.Value} - {d.Value}");
                }
            }
            catch
            {
                Console.WriteLine("Неверный формат");
            }
        }
    }
}
