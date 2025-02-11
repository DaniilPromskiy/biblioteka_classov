using System;
using System.IO;
using YourFullName_CatFramework;

namespace PromskiyDaniil_CatApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число кота чтобы сгенерировать: ");
            uint catCount = uint.Parse(Console.ReadLine());
            Cat[] cats = GenerateRandomCats(catCount);

            Console.Write("ВВедите число чтобы сохранить информацию: ");
            string path = Console.ReadLine();
            DisplayCatInfo(cats, path);
        }

        static Cat[] GenerateRandomCats(uint count)
        {
            Random random = new Random();
            Cat[] cats = new Cat[count];

            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    try
                    {
                        if (random.Next(2) == 0) 
                        {
                            double weight = random.NextDouble() * 110 + 50; 
                            int fluffiness = random.Next(-20, 121); 
                            cats[i] = new Tiger(weight, fluffiness);
                        }
                        else
                        {
                            int fluffiness = random.Next(-20, 121); 
                            cats[i] = new CuteCat(fluffiness);
                        }
                        break;
                    }
                    catch (CatException ex)
                    {
                        Console.WriteLine($"Exception occurred: {ex.Message}");
                    }
                }
            }

            return cats;
        }

        static void DisplayCatInfo(Cat[] catsArr, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var cat in catsArr)
                {
                    string info = cat.FluffinessCheck() + "\n" + cat.ToString();
                    Console.WriteLine(info);
                    writer.WriteLine(info);
                }
            }
        }
    }
}