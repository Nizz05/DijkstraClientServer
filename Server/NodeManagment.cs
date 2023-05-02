using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class NodeManagment
    {
        private Dictionary<string, Node> nodes;
        public NodeManagment() 
        {
            nodes = new Dictionary<string, Node>();
        }

        public bool AddNode(string desc) 
        { 
            if (nodes.ContainsKey(desc)) 
            {
                return false;
            }
            nodes[desc] = new Node(desc);
            return true;
        }
        public bool AddConnection(string from, string to, int weight) 
        {
            return  nodes.ContainsKey(from) &&
                    nodes.ContainsKey(to) &&
                    nodes[from].AddNeigh(nodes[to], weight) && 
                    nodes[to].AddNeigh(nodes[from], weight);
        }
    }
}
