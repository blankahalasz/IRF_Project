using IRF_beadando;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Test
{
    public class EredmenyControllerTestFixture
    {
        [Test,
         TestCase ("1998/03/17", false),
         TestCase ("1998-03-17", false),
         TestCase ("1998.03.17", true)
            ]
        public void TestValidateDatum(System.DateTime datum, bool expectedResult)
        {
            //Arrange
            var eredmenyController = new EredmenyController();
            //Act
            var actualResult = eredmenyController.ValidateDatum(datum);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test,
         TestCase("123", true)
        ]

        public void TestValidatePont(string pont, bool expectedResult)
        {
            //Arrange
            var eredmenyController = new EredmenyController();
            //Act
            var actualResult = eredmenyController.ValidatePont(Convert.ToInt32(pont)); ;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
