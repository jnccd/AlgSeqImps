using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSeqImps.AlgImps
{
    class BoyerMoore : Alg
    {
        public BoyerMoore() : base("Boyer-Moore")
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

            // Build rightocc based table for jumps
            Dictionary<char, int> badmatchtable = new();
            for (int i = 0; i < m; i++)
            {
                var v = m - i - 1;
                if (i == m - 1)
                    v = m;

                if (!badmatchtable.ContainsKey(pattern[i]))
                    badmatchtable.Add(pattern[i], v);
                if (badmatchtable[pattern[i]] < v)
                    badmatchtable[pattern[i]] = v;
            }
            Console.WriteLine("Bad Match Table: ");
            foreach (var kvp in badmatchtable)
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");

            // Text traversal
            List<int> matches = new();
            for (int i = m - 1; i < text.Length; )
            {
                // Check pattern using right to left scan in position i
                int miss = -1;
                for (int j = 0; j < m; j++)
                {
                    if (text[i - j] != pattern[m - j - 1])
                    {
                        miss = i - j;
                        break;
                    }
                }

                // If we missed: jump using bad character rule, else add current position to matches
                if (miss > 0)
                {
                    if (!badmatchtable.ContainsKey(text[miss]))
                        i += m;
                    else
                        i += badmatchtable[text[miss]];
                }
                else
                {
                    matches.Add(i - m + 1);
                    i++;
                }
            }

            Console.WriteLine("Matches: ");
            for (int i = 0; i < text.Length; i++)
            {
                if (matches.Contains(i))
                    Console.WriteLine(text[i] + " x");
                else
                    Console.WriteLine(text[i]);
            }

            Console.WriteLine();
        }
    }
}
