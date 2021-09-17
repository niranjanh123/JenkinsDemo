using NUnit.Framework;
using UnitTest;
namespace UnitTestDemo
{
    [TestFixture]
    public class UnitTestDemo
    {
            [Test]
            public void Add_AcceptingTwoDoubleValues_ReturnsSum() 
            {
               
                float ExpectedResult = 8.8f;
                ICalcOps arithOps = new CalcOps();
                float ActualResult = arithOps.Add(4.4f, 4.4f);
                Assert.AreEqual(ExpectedResult, ActualResult);
                Assert.That(ActualResult, Is.Not.EqualTo(ExpectedResult));
                Assert.That(ActualResult, Is.GreaterThan(2));
                Assert.That(ActualResult, Is.InRange(5, 10));
            }

            public void String_Input1_Output1()
            {
            ICalcOps arithOps = new CalcOps();
            string result = arithOps.Comp("Niranjan");
            Assert.That(result, Is.EqualTo("abcdefg"));
            Assert.That(result, Is.Not.EqualTo("mnop"));
        }
            [Test]
            public void Sub_AcceptingTwoDoubleValues_ReturnsDiff() 
            {
                float ExpectedResult = 3.0f;
                ICalcOps arithOps = new CalcOps();
                float ActualResult = arithOps.Sub(5.0f, 2.0f);
                Assert.AreEqual(ExpectedResult, ActualResult);
            }
            [Test]
            public void Mul_AcceptingTwoDoubleValues_ReturnsProduct() 
            {

                float ExpectedResult = 63.0f;
                ICalcOps arithOps = new CalcOps();
                float ActualResult = arithOps.Mul(9.0f, 7.0f);
                Assert.AreEqual(ExpectedResult, ActualResult);
            }
            [Test]
            public void Div_AcceptingTwoDoubleValues_ReturnsQua()
            {
                float ExpectedResult = 4.0f;
                ICalcOps arithOps = new CalcOps();
                float ActualResult = arithOps.Div(16.8f, 4.2f);
                Assert.AreEqual(ExpectedResult, ActualResult);
            }
        [TestCase(3.0, 2.0, 5.0)]
        [TestCase(5.0, 2.0, 7.0)]
        public void Add_Get2Values_ReturnsSum(double n1, double n2, double result)
        {
            ICalcOps arithOps = new CalcOps();
            //Act
            double actualResult = arithOps.Addition(n1, n2);
            //Assert
            Assert.That(actualResult, Is.EqualTo(result));
        }

        [TestCase(6.0, 2.0, 36.0)]
        [TestCase(9.0, 3.0, 729.0)]
        public void Power_Get2Values_ReturnsXpowY(double n1, double n2, double result)
        {
            ICalcOps arithOps = new CalcOps();
            //Act
            double actualResult = arithOps.Power(n1, n2);
            //Assert
            Assert.That(actualResult, Is.EqualTo(result));
        }

        [TestCase(6000.0,72000.0)]

        public void Net_salary_Get1Value_Returns1Value(double amt,double res)
        {
            ICalcOps arithOps = new CalcOps();
            //Act
            double actualResult = arithOps.Net_salary(amt);
            //Assert
            Assert.That(actualResult, Is.EqualTo(res));

        }
    }
}
