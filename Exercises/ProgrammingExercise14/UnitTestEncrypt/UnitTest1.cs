using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingExercise14;

namespace ProgrammingExercise14.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void SingleEncSingleEnc()
        {
            //Arrange
            Util Tool = new Util();
            //Act
            
            //Assert
        }
    }
}

namespace UnitTestEncrypt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CleanText()
        {
            //Arange
            Util tool = new Util();
            //Act 
            string mac = "$$a%%b  &&c  d**e$$f";
            int[] test1 = Util.Clean(mac);
            //Assert 
            int[] m = new int[] { 65, 66, 67, 68, 69, 70 };
            for(int i = 0; i < m.Length; i++)
            {
                Assert.AreEqual(m[i], test1[i]);
            }
     
        }
    }
}
