using System;
using System.Collections.Generic;
using System.Text;

namespace MSTlib
{
    internal struct Edge
    {
        public int start;
        public int end;
        public int cost;

        public Edge(int start, int end, int cost)
        {
            this.start = start;
            this.end = end;
            this.cost = cost;
        }
    }
}
