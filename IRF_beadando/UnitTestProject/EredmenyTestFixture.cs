using IRF_beadando;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class EredmenyTestFixture
    {
        [Test,
         TestCase ("abcd", false),
         TestCase ("1", false),
         TestCase ("1234", false),
         TestCase ("123,4", false),
         TestCase ("123", true)
            ]
        public void TestValidatePont(string pont, bool expectedResult)
        {
            //Arrange
            var form3 = new Form3();
            //Act
            var actualResult = form3.ValidatePont(pont);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

            
        }
    }
}
