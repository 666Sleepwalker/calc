using NUnit.Framework;
using CalculatorApp;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Plus_6plus7_13()
        {
            Calculator calc = new Calculator();

            double res = calc.Plus(6, 7);

            Assert.AreEqual(13, res);
        }

        [Test]
        public void Minus_10minus7_3()
        {
            Calculator calc = new Calculator();

            double res = calc.Minus(10, 7);

            Assert.AreEqual(3, res);
        }

        [Test]
        public void Multi_4multi7_28()
        {
            Calculator calc = new Calculator();

            double res = calc.Multi(4, 7);

            Assert.AreEqual(28, res);
        }

        [Test]
        public void Divide_10divide2_5()
        {
            Calculator calc = new Calculator();

            double res = calc.Divide(10, 5);

            Assert.AreEqual(2, res);
        }

        [Test]
        public void S_Triangle_2Multi2Divide2_2()
        {
            Calculator calc = new Calculator();

            double res = calc.S_Triangle(4, 4);                       

            Assert.AreEqual(8, res);
        }

        [Test]
        public void S_Circle_PiMulti2Divide2_12()
        {
            Calculator calc = new Calculator();

            double res = calc.S_Circle(2);            

            Assert.GreaterOrEqual(res, 12);
        }

        [Test]
        public void Average_4_4_4_4_Return4()
        {
            Calculator calc = new Calculator();

            double[] array = new double[]
            {
                4,4,4,4
            };

            double res = calc.Average(array);

            Assert.AreEqual(4, res);
        }

        [Test]
        public void Average_6_6_6_6_Return6()
        {
            Calculator calc = new Calculator();

            double[] array = new double[]
            {
                6,6,6,6
            };

            double res = calc.Average(array);

            Assert.AreEqual(6, res);
        }

        [Test]
        public void Average_6_6_6_6_6_6_Return6()
        {
            Calculator calc = new Calculator();

            double[] array = new double[]
            {
                6,6,6,6,6,6
            };

            double res = calc.Average(array);

            Assert.AreEqual(6, res);
        }

        [Test]
        public void Average_1_2_3_4_5_6_Return3Dot5()
        {
            Calculator calc = new Calculator();

            double[] array = new double[]
            {
                1,2,3,4,5,6
            };

            double res = calc.Average(array);

            Assert.GreaterOrEqual(res, 3.5);
        }
    }
}