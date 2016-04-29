using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorioAnalysis.FileAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioAnalysis.FileAnalysis.Tests
{
    [TestClass()]
    public class ItemGroupAnalysisTests
    {
        [TestMethod()]
        public void GetTableTest()
        {
           ItemGroupAnalysis iga=new ItemGroupAnalysis();
            iga.AnalysisFile();
            
        }
    }
}