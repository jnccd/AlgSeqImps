using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSeqImps.AlgImps.KewordTree
{
    class KeywordTree : Alg
    {
        public KeywordTree() : base("Keyword-Tree")
        {

        }

        public override void Run()
        {
            Console.Write("Please input the patterns seperated by ',': ");
            string[] patterns = Console.ReadLine().Replace(" ", "").ToLower().Split(',');
            Console.WriteLine();

            // Keyword Tree construction
            Node root = new(null);
            Node curNode = null;
            for (int j = 0; j < patterns.Length; j++)
            {
                string pattern = patterns[j];
                curNode = root;
                for (int i = 0; i < pattern.Length; i++)
                {
                    // If a node with the letter of the pettern is found, go on it, if not make a node with the letter and then go on that
                    Node tmp = curNode.Nodes.FirstOrDefault(x => x.letter == pattern[i]);
                    if (tmp != null)
                        curNode = tmp;
                    else
                    {
                        Node n = new(pattern[i]);
                        n.parent = curNode;
                        curNode.Nodes.Add(n);
                        curNode = n;
                    }

                    // At the end of a pattern set the label of the node
                    if (i == pattern.Length - 1)
                        curNode.label = j;
                }
            }

            Console.WriteLine("Compact keywordtree representation:");
            TraversePrint(root);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Please input the text: ");
            string text = Console.ReadLine().Replace(" ", "").ToLower();

            // Naive keyword tree traversal
            curNode = root;
            for (int i = 0; i < text.Length; i++)
            {
                // Print current text letter and whether we found anything based on keyword labels
                if (curNode.label != -1)
                    Console.WriteLine($" x {patterns[curNode.label]}");
                else
                    Console.WriteLine();
                Console.Write(text[i]);

                // Move into next node or root
                curNode = curNode.Nodes.FirstOrDefault(x => x.letter == text[i]);
                if (curNode == null)
                    curNode = root;
            }

            Console.WriteLine();
        }

        // Just for visuals
        void TraversePrint(Node n, int depth = 0)
        {
            if (n.parent != null && n.parent.Nodes.Count > 1)
                Console.Write("\n" + new string(Enumerable.Repeat(' ', depth).ToArray()));

            if (n.letter != null)
                Console.Write(n.letter);
            else
                Console.Write("*");

            if (n.Nodes.Count > 1)
                depth++;
            foreach (Node c in n.Nodes)
                TraversePrint(c, depth);
        }
    }
}
