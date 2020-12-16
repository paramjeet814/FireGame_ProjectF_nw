using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame_ProjectF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_ProjectF.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void btnoptionTest()
        {
            GenreateRandom gr = new GenreateRandom();
            int y = gr.array();
            if (y>1)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }
    }
}