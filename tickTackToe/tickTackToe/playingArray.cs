using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickTackToe
{
    internal class playingArray
    {
        public Random rnd = new Random();
        public char[,] array = new char[3, 3]
        {
            {'_','_','_'},
            {'_','_','_'}, 
            {'_','_','_'}
        };

        public void DrawArray()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i +" ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }

        }


    }
}
