using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSeqImps.AlgImps
{
    class Naive : Alg
    {
        public Naive() : base("Naive")
        {

        }

        public override void Run()
        {
            Console.Write("Please input a text: ");
            string text = Console.ReadLine().Replace(" ", "").ToLower();
            Console.Write("Please input a pattern: ");
            string pattern = Console.ReadLine().Replace(" ", "").ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - pattern.Length + 1)
                {
                    bool fits = true;
                    for (int j = 0; j < pattern.Length; j++)
                    {
                        if (text[i + j] != pattern[j])
                            fits = false;
                    }

                    if (fits)
                        Console.WriteLine(text[i] + " x");
                    else
                        Console.WriteLine(text[i]);
                }
                else
                    Console.WriteLine(text[i]);
            }

            Console.WriteLine();
        }
    }
}
