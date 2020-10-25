using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                int indexForShoot = int.Parse(command);

                if(indexForShoot > targets.Count - 1)
                {
                    continue;
                }

                int currTargetValue = targets[indexForShoot];
                targets[indexForShoot] = -1;

                for (int i = 0; i < targets.Count; i++)
                {
                    
                    if(targets[i] == -1)
                    {
                        continue;
                    }
                    else
                    {
                        if (targets[i] > currTargetValue)
                        {
                            targets[i] -= currTargetValue;
                            continue;
                        }
                        if (targets[i] <= currTargetValue)
                        {
                            targets[i] += currTargetValue;
                        }
                    }
                    

                }
            }

            int shootedTargets = 0;

            for (int i = 0; i < targets.Count; i++)
            {
                if(targets[i] == -1)
                {
                    shootedTargets++;
                }
            }

            Console.Write($"Shot targets: { shootedTargets} -> ");
            Console.WriteLine(string.Join(" ", targets));
            
        }
    }
}
