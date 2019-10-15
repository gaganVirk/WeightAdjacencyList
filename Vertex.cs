using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightAdjacencyList
{
    class Vertex
    {
        public int Id { get; set; }

        public Dictionary<Vertex, int> Weights = new Dictionary<Vertex, int>();

        public List<Vertex> Adj = new List<Vertex>();

        public Vertex(int id)
        {
            Id = id;
        }

        

    }
}
