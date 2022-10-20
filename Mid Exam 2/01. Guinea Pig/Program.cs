using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gramsOfFood = double.Parse(Console.ReadLine()) * 1000;
            double gramsOfHey = double.Parse(Console.ReadLine()) * 1000;
            double gramsOfCover = double.Parse(Console.ReadLine()) * 1000;
            double guineaPigWeightInGrams = double.Parse(Console.ReadLine()) * 1000;

            const double DailyFoodConsumed = 300;
            bool isEnough = true;


            for (int day = 1; day <= 30; day++)
            {
                gramsOfFood -= DailyFoodConsumed;

                isEnough = CheckQuantity(gramsOfFood);

                if (!isEnough)
                {
                    break;
                }

                if (day % 2 == 0)
                {
                    gramsOfHey -= gramsOfFood * 0.05;
                    isEnough = CheckQuantity(gramsOfHey);

                    if (!isEnough)
                    {
                        break;
                    }
                }
                if (day % 3 == 0)
                {
                    gramsOfCover -= guineaPigWeightInGrams / 3;
                    isEnough = CheckQuantity(gramsOfCover);

                    if (!isEnough)
                    {
                        break;
                    }
                }
            }

            double kgOfFood = gramsOfFood / 1000;
            double kgOfHey = gramsOfHey / 1000;
            double kgOfCover = gramsOfCover / 1000;

            if (!isEnough)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {kgOfFood:f2}, Hay: {kgOfHey:f2}, Cover: {kgOfCover:f2}.");
            }
        }

        private static bool CheckQuantity(double grams)
        {
            if (grams <= 0)
            {
                return false;
            }

            return true;
        }
    }
    
}
