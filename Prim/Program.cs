using MSTlib;
using System;
using System.IO;

namespace Prim
{
    class Program
    {
        static void Main(string[] args)
        {
            var mst = new MST();
            string line;
            using (StreamReader srStreamRdr = new StreamReader(@"edges.txt"))
            {
                while ((line = srStreamRdr.ReadLine()) != null)
                {
                    string[] values = line.Split(new Char[] { ' ' });
                    mst.AddEdge(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]));
                }
            }
            mst.Execute();
            Console.WriteLine(mst.Cost);
            Console.ReadKey();
        }
    }
}
