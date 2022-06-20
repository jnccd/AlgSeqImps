using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSeqImps.AlgImps
{
    public class Zbox : Alg
    {
        public Zbox() : base("Z-Box")
        {

        }

        public override void Run()
        {
            Console.Write("Please input a word: ");
            string input = Console.ReadLine().Replace(" ", "").ToLower();
            Console.WriteLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);

                int lcpi = input.Lcpi(i);

                if (lcpi == 0)
                {
                    Console.WriteLine($"\t∅\tε");
                }
                else
                {
                    string zBox = input[i..(i + lcpi)];
                    Console.WriteLine($"\t[{i+1}..{i + lcpi}]\t{zBox}");
                }
            }

            Console.WriteLine();
        }
    }
}
