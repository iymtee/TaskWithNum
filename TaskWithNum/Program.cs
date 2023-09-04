using System;
using System.Collections.Generic;

namespace TaskWithNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод списка чисел
            Console.WriteLine("Введите числа, разделяя их запятыми:");
            string strInput = Console.ReadLine();
            string[] inputArray = strInput.Split(',');

            // Создание списка для хранения результатов
            List<string> lstResult = new List<string>();

            //Обработка массива
            foreach (string numStr in inputArray)
            {
                if (int.TryParse(numStr.Trim(), out int num))
                {
                    string strOut = "";

                    if (num % 3 == 0)
                        strOut += "fizz";
                    if (num % 5 == 0)
                        strOut += "buzz";
                    if (num % 3 == 0 && num % 5 == 0)
                        strOut = "fizz-buzz";

                    if (string.IsNullOrEmpty(strOut))
                        strOut = numStr.ToString();

                    lstResult.Add(strOut);
                }
                else
                {
                    Console.WriteLine($"Ошибка: {numStr} не является числом и будет проигнорировано.");
                }
            }
            Console.WriteLine("Результат:");
            Console.WriteLine(string.Join(", ", lstResult));
            Console.ReadLine();
        }
    }
}
