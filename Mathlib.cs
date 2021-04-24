using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    [TestFixture]
    public class MathLib
    {
        [Test]
        public void Testing()
        {
            Assert.Throws<DivideByZeroException>(new TestDelegate(() => Divide(1,0)));
        }
        [Test]
        [TestCaseSource(nameof(CompareTwoNumbersTestData))]
        public int Divide(int dividend, int devisor)
        {
            return dividend / devisor;
        }
        [Test]
        [TestCaseSource(nameof(CompareTwoNumbersTestData))]
        [TestCase(1,2,ExpectedResult=-1 )]
        public int CompareTwoNumbers(int firstNo, int secondNo)
        {
            if (firstNo <= 0 && secondNo <= 0)
            {
                return 0;
            }

            if (firstNo > secondNo)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        private static IEnumerable<TestCaseData> CompareTwoNumbersTestData
        {
            get
            {
                yield return new TestCaseData(-1, 0, -1);
                yield return new TestCaseData(1, 2, -1);
                yield return new TestCaseData(2, 1, 1);
            }
        }
    }
}
