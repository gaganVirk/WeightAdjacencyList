using System;
using System.Collections.Generic;


namespace WeightAdjacencyList
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextReader reader = Console.In;
            //Console.SetIn(new StreamReader("weightAdjList.txt"));

            List<Vertex> vertices = new List<Vertex>();
            Vertex v1 = new Vertex(0);

            int size = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < size; i++)
            {
                vertices.Add(new Vertex(i));
            }

            string line = Console.ReadLine();
            while(line != "#")
            {
                string[] array = line.Split(' ');
                int token1 = int.Parse(array[0]);
                int token2 = int.Parse(array[1]);
                int cost = int.Parse(array[2]);

                vertices[token1].Adj.Add(vertices[token2]);
                vertices[token1].Weights.Add(vertices[token2], cost);

                line = Console.ReadLine();
            }

            foreach (var e in vertices)
            {
                   string s = e.Id + ": ";

                foreach (var d in e.Adj)
                {
                    s += d.Id + "(" + e.Weights[d] + ") ";

                }
                Console.WriteLine(s);
            }


          // Console.SetIn(reader);
           // Console.ReadLine();
        }
    }
}
