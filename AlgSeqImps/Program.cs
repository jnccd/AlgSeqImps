using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgSeqImps
{
    class Program
    {
        static readonly Type[] algTypes = (from domainAssembly in AppDomain.CurrentDomain.GetAssemblies()
                                           from assemblyType in domainAssembly.GetTypes()
                                           where assemblyType.IsSubclassOf(typeof(Alg))
                                           select assemblyType).ToArray();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");
            Console.WriteLine();

            List<Alg> algs = new List<Alg>();
            foreach (var algType in algTypes)
                algs.Add((Alg)Activator.CreateInstance(algType));

            Console.WriteLine("I found the following Algorithms:");
            foreach (var alg in algs)
                Console.WriteLine(alg.name);

            while (true)
            {
                Console.WriteLine();
                Console.Write("Please type a unique prefix of the name of the Algorithm you want to use: ");
                string inAlgName = Console.ReadLine().ToLower();

                Alg chosenAlg = algs.FirstOrDefault(x => x.name.ToLower().StartsWith(inAlgName));

                if (chosenAlg != null && !string.IsNullOrWhiteSpace(inAlgName))
                {
                    Console.WriteLine($"Starting {chosenAlg.name} Algorithm...");
                    Console.WriteLine();

                    while (true)
                        chosenAlg.Run();
                }
                else
                {
                    Console.WriteLine("I dont know that one");
                }
            }
        }
    }
}
