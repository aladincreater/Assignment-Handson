using NUnit.Framework;

namespace CalculatorLibTest
{
    [TestFixture]
    public class Calculator
    {
        [Test]
        [TestCaseSource(nameof(AddCases))]
        public void cal(int fnum,int snum)
        {
            int sum = add(fnum, snum);
            Assert.That(sum, Is.EqualTo(fnum+snum));
        }
        [Category("Math")]
        [Test, Order(1)]
        [TestCase(1,2, ExpectedResult =3)]
        public int add(int i,int j)
        {
            if(i> 0 && j>0)
            {
                return i + j;
            }
            return 0;
        }

        [Test, Order(2)]
        [TestCase(1, 2, ExpectedResult = -1)]
        public int sub(int i, int j)
        {
            if (i > 0 && j > 0)
            {
                return i - j;
            }
            return 0;
        }
        [Test, Order(3)]
        [TestCase(1, 2, ExpectedResult = 2)]
        public int multiply(int i, int j)
        {
            if (i > 0 && j > 0)
            {
                return i * j;
            }
            return 0;
        }
        [Test, Order(4)]
        [TestCase(1, 2, ExpectedResult = 0)]
        public double divide(int i,int j)
        {
            if(i> 0 && j>0)
            {
                return i / j;
            }
            return 0;
        }
        static readonly object[] AddCases =
        {
            new object[] {1,1},
            new object[] {50,50},
            new object[] {22,13}
        };
    }
}