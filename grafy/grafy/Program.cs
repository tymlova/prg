using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class Program
    {
        class Node
        {
            int index;
            private List<Node> neighbours;
            public Node(int index)
            {
                this.index = index;
                neighbours = new List<Node>();
            }
            public void AddNeigbour(Node node)
            {
                if (neighbours.Contains(node))
                {
                    Console.WriteLine("node" + node.index + "is already a neighbour");
                }
                else
                {
                    neighbours.Add(node);
                    Console.WriteLine("added" + node.index + "to the graph");
                }
            }


            public Node MoveToNeigbour(int index)
            {
                foreach (Node node in neighbours)
                {
                    if (neighbour.index == index)
                    {
                        return neighbour;
                    }
                }
                Console.WriteLine("Node" + index + "is nbot a neighbour of " + this.index);
            }
        }
        static void Main(string[] args)
        {/*
          * 1-4,6
          * 2-3,5,6
          * 3-2,5
          * 4-1,6
          * 5-2,3
          * 6-1,2,4
          */

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            node1.AddNeigbour(node4);
            node1.AddNeigbour(node6);

            node2.AddNeigbour(node3);
            node2.AddNeigbour(node5);
            node2.AddNeigbour(node6);

            node3.AddNeigbour(node2);
            node3.AddNeigbour(node5);

            node4.AddNeigbour(node1);
            node4.AddNeigbour(node6);

            node5.AddNeigbour(node2);
            node5.AddNeigbour(node3);

            node6.AddNeigbour(node1);
            node6.AddNeigbour(node2);
            node6.AddNeigbour(node4);

            Node currentNode = node1;
            while (true)
            {
                Console.WriteLine("current node: " + curentNode.GetIndex());
                Console.WriteLine("neigbours: ");
                foreach (Node node in currentNode.GetNeighboursIndex())
                {
                    Console.WriteLine(neighbourIndex + " ");
                }
              
            }
        }
         
    }
}
