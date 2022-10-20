using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            int shootsCount = 0;
            while(command != "End")
            {
                int indexToShoot = int.Parse(command);
                if(indexToShoot>=0 && indexToShoot < targets.Length && targets[indexToShoot]!=-1)
                {
                    ShootTarget(indexToShoot, targets);
                    shootsCount++;
                }


                command = Console.ReadLine();   
            }
            Console.WriteLine($"Shot targets: {shootsCount} -> {string.Join(" ",targets)}");
        }
        static void ShootTarget(int indexToShoot, int[] targets)
        {
            var valueOfTarget = targets[indexToShoot];
            targets[indexToShoot] = -1;
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] == -1)
                {
                    continue;
                }
                if (targets[i] > valueOfTarget)
                {
                    targets[i] -= valueOfTarget;

                }
                else
                {
                    targets[i] += valueOfTarget;
                }

            }
            
        }
    }
}
