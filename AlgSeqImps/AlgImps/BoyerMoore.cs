using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSeqImps.AlgImps
{
    class BoyerMoore : Alg
    {
        public BoyerMoore() : base("BoyerMoore")
        {

        }

        public override void Run()
        {
            Console.Write("Please input a text: ");
            string text = Console.ReadLine().Replace(" ", "").ToLower();
            Console.Write("Please input a pattern: ");
            string pattern = Console.ReadLine().Replace(" ", "").ToLower();

            int n = text.Length;
            int m = pattern.Length;

            int[] badmatch = new int[pattern.Length];
            for (int i = 0; i < badmatch.Length; i++)
            {
                badmatch[i] = m - i - 1;

                for (int j = 0; j < i; j++)
                    if (pattern[i] == pattern[j])
                        badmatch[j] = badmatch[i];
            }
            for (int i = 0; i < badmatch.Length; i++)
            {
                Console.Write($"{pattern[i]} - {badmatch[i]}");
            }



            Console.WriteLine();
        }
    }
}
