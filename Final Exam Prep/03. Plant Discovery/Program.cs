using System;
using System.Linq;
using System.Collections.Generic; 

namespace _03._Plant_Discovery
{
    public class Plant
    {
        private List<double> rating;
        public Plant(string name, int rarity)
        {
            Name = name;
            Rarity = rarity;
            rating = new List<double>();
        }

        public string Name { get; set; }
        public int Rarity { get; set; }
        public IReadOnlyCollection<double> Rating
            => rating;
        public void AddRating(double rating)
        {
            this.rating.Add(rating);
        }
        public void ClearRating()
        {
            rating.Clear();
        }
        public double AverageRating()
        {
            if (Rating.Count == 0)
            {
                return 0.0;
            }

            double averageRating = Rating.Sum() / Rating.Count;
            return averageRating;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");
                string name = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                Plant plant = new Plant(name, rarity);
                plants.Add(plant);
            }

            string[] token = Console.ReadLine().Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

            while (token[0] != "Exhibition")
            {
                string action = token[0];
                string plantName = token[1];

                if (!plants.Any(x => x.Name == plantName))
                {
                    Console.WriteLine("error");
                    token = Console.ReadLine().Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                if (action == "Rate")
                {
                    double rating = double.Parse(token[2]);
                    Plant currentPlant = plants.First(x => x.Name == plantName);
                    currentPlant.AddRating(rating);
                }
                else if (action == "Update")
                {
                    int newRarity = int.Parse(token[2]);
                    Plant currentPlant = plants.First(x => x.Name == plantName);
                    currentPlant.Rarity = newRarity;
                }
                else if (action == "Reset")
                {
                    Plant currentPlant = plants.First(x => x.Name == plantName);
                    currentPlant.ClearRating();
                }


                token = Console.ReadLine().Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plants)
            {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.AverageRating():f2}");
            }
        }

    }
}
