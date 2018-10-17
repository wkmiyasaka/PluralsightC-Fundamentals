using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 200;

            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesholdAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Scott's grade book";

            Console.WriteLine(g2.Name);
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
