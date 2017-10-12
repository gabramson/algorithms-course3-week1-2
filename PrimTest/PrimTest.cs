using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTlib;

namespace PrimTest
{
    [TestClass]
    public class PrimTest
    {
        [TestMethod]
        public void TestMST()
        {
            MST mst = new MST();
            mst.AddEdge(1, 2, 1);
            mst.AddEdge(1, 3, 3);
            mst.AddEdge(1, 4, 4);
            mst.AddEdge(2, 3, 2);
            mst.AddEdge(3, 4, 5);
            mst.Execute();
            Assert.AreEqual(7, mst.Cost);
        }
    }
}
