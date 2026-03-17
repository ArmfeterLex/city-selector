using System;

class Program
{
    static void Main(string[] args)
    {
        string[] cities = { "Брест", "Витебск", "Гомель", "Минск", "Полоцк" };

        while (true)
        {
            Console.WriteLine("Введите первую букву города или номер (1-5):");
            string input = Console.ReadLine();
            try
            {
                if (int.TryParse(input, out int cityIndex))
                {
                    cityIndex--; 

                    if (cityIndex >= 0 && cityIndex < cities.Length)
                    {
                        Console.WriteLine($"Выбран город: {cities[cityIndex]}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Некорректный номер города.");
                    }
                }
                else
                {
                    string firstLetter = input.Substring(0, 1).ToUpper(); 

                    bool found = false;
                    for (int i = 0; i < cities.Length; i++)
                    {
                        if (cities[i].StartsWith(firstLetter))  
                        {
                            Console.WriteLine($"Выбран город: {cities[i]}");
                            found = true;
                            break; 
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Город с такой первой буквой не найден.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            Console.WriteLine(); 
        }
        Console.WriteLine("Программа завершена.");
        Console.ReadKey();
    }
}