using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSeqImps.AlgImps.KewordTree
{
    class Node
    {
        public List<Node> Nodes = new();
        public Node parent = null;
        public int label = -1;
        public char? letter;

        public Node(char? letter)
        {
            this.letter = letter;
        }
    }
}
