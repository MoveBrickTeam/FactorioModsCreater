using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorioAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioAnalysis.Tests
{
    [TestClass()]
    public class FolderAnalysisTests
    {
        [TestMethod()]
        public void testLuaTest()
        {
            FolderAnalysis fa=new FolderAnalysis();
            fa.testLua();
            //Assert.Fail();
        }
    }
}