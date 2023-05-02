using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Node
    {
        private string desc;
        private Dictionary<Node, int> neigh;
        
        public string Desc
        {

            get { return Desc; }
            private set { Desc = value; } 
        }

        public Node(string desc) 
        {
            Desc= desc;
        }

        public bool AddNeigh(Node n, int weight) 
        {
            if(neigh.ContainsKey(n))
            {
                return false;
            }
            neigh[n] = weight;
            return true;
        }
    }
}
