using System;
using System.Collections.Generic;
using System.Text;

namespace MSTlib
{
    internal class EdgeList
    {
        private Dictionary<(int, int), Edge> edgeList = new Dictionary<(int, int), Edge>();

        public void Add(int start, int end, int cost)
        {
            if (start < end)
            {
                edgeList.Add((start, end), new Edge(start, end, cost));
            }
            else
            {
                edgeList.Add((end, start), new Edge(end, start, cost));
            }
        }

        public bool Contains(int start, int end)
        {
            if (start < end)
            {
                return edgeList.ContainsKey((start, end));
            }
            else
            {
                return edgeList.ContainsKey((end, start));
            }
        }

        public int GetCost(int start, int end)
        {
            if (start < end)
            {
                return edgeList[(start, end)].cost;
            }
            else
            {
                return edgeList[(end, start)].cost;
            }
        }
    }
}
