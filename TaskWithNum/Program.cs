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

                    List<string> lstOut = new List<string>();

                    if (num % 3 == 0)
                        lstOut.Add("fizz");
                    if (num % 5 == 0)
                        lstOut.Add("buzz");
                    if (num % 7 == 0)
                        lstOut.Add("guzz");
                    if (num % 4 == 0)
                        lstOut.Add("muzz");

                    if (lstOut.Count == 0)
                        lstOut.Add(numStr.ToString());

                    lstResult.Add(string.Join("-", lstOut));
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
