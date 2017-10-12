using System;
using System.Collections.Generic;

namespace MSTlib
{
    public class MST
    {
        private EdgeList edgeList = new EdgeList();
        private VertexList vertexList = new VertexList();
        private Dictionary<int, int> mstKeys = new Dictionary<int, int>();

        public int Cost { private set; get; } = 0;

        public void AddEdge(int start, int end, int cost)
        {
            if (!vertexList.ContainsVertex(start))
            {
                vertexList.Add(start);
                if (mstKeys.Count == 0)
                {
                    mstKeys.Add(start, 0);
                }
                else
                {
                    mstKeys.Add(start, int.MaxValue);
                }
            }
            if (!vertexList.ContainsVertex(end))
            {
                vertexList.Add(end);
                mstKeys.Add(end, int.MaxValue);
            }
            vertexList.AddNeighbor(start, end);
            vertexList.AddNeighbor(end, start);
            edgeList.Add(start, end, cost);
        }

        public void Execute()
        {
            int nextVertex;
            int vCost;

            while (mstKeys.Count > 0)
            {
                nextVertex = GetMinVertex();
                Cost += mstKeys[nextVertex];
                foreach(var v in vertexList[nextVertex].OutNeighbors)
                {
                    vCost = edgeList.GetCost(nextVertex, v);
                    if ((mstKeys.ContainsKey(v)) && (mstKeys[v]> vCost))
                    {
                        mstKeys[v] = vCost;
                    }
                }
                mstKeys.Remove(nextVertex);
            }
        }

        private int GetMinVertex()
        {
            int minCost = int.MaxValue;
            int minIndex = -1;

            foreach (var (k,v) in mstKeys)
            {
                if (v < minCost)
                {
                    minCost = v;
                    minIndex = k;
                }
            }
            return minIndex;
        }
    }
}
