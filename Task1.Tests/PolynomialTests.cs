using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task1.Tests
{
    public class PolynomialTests
    {
        [TestCase(new[] {1, -2, 3}, 2, ExpectedResult = 3)]
        [TestCase(new[] {2, 5, 1, -2, 3 }, 3, ExpectedResult = 303)]
        [TestCase(new[] {6}, 2, ExpectedResult = 6)]
        [TestCase(new[] { 0, 0, 0, 0, 0 }, 5, ExpectedResult = 0)]
        [TestCase(new[] { 3, 4, 0 }, 2, ExpectedResult = 20)]
        [TestCase(new[] { 7, 8, 9, 3 }, 0, ExpectedResult = 3)]
        [TestCase(new[] { 0, 0, 0, 0, 0 }, 0, ExpectedResult = 0)]
        public double Calculate_ResultOfPolinomialExpression(int[] coefficients, double variable)
        {
            return (new Polynomial(coefficients)).Calculate(variable);
        }

        [TestCase(new[] { 1, -2, 3 }, 2, ExpectedResult = -3)]
        [TestCase(new[] { 2, 5, 1, -2, 3 }, 3, ExpectedResult = -303)]
        [TestCase(new[] { 6 }, 2, ExpectedResult = -6)]
        [TestCase(new[] { 0, 0, 0, 0, 0 }, 5, ExpectedResult = 0)]
        [TestCase(new[] { 3, 4, 0 }, 2, ExpectedResult = -20)]
        [TestCase(new[] { 7, 8, 9, 3 }, 0, ExpectedResult = -3)]
        [TestCase(new[] { 0, 0, 0, 0, 0 }, 0, ExpectedResult = 0)]
        public double InvertAndCalculate_ResultOfPolinomialExpression(int[] coefficients, double variable)
        {
            return (-(new Polynomial(coefficients))).Calculate(variable);
        }

        [TestCase(new[] { 1, -2, 3 }, new[] {0, 0, 0}, 2, ExpectedResult = 3)]
        [TestCase(new[] {0, 0}, new[] { 2, 5, 1, -2, 3 }, 3, ExpectedResult = 303)]
        [TestCase(new[] { 6 }, new[] {1, -2, 3}, 2, ExpectedResult = 9)]
        public double AddAndCalculate_ResultOfPolinomialExpression(int[] coefficients1, int[] coefficients2, double variable)
        {
            return (new Polynomial(coefficients1) + new Polynomial(coefficients2)).Calculate(variable);
        }

        [TestCase(new[] { 1, -2, 3 }, new[] { 0, 0, 0 }, 2, ExpectedResult = 3)]
        [TestCase(new[] { 0, 0 }, new[] { 2, 5, 1, -2, 3 }, 3, ExpectedResult = -303)]
        [TestCase(new[] { 6 }, new[] { 1, -2, 3 }, 2, ExpectedResult = 3)]
        public double SubstractAndCalculate_ResultOfPolinomialExpression(int[] coefficients1, int[] coefficients2, double variable)
        {
            return (new Polynomial(coefficients1) - new Polynomial(coefficients2)).Calculate(variable);
        }

        [TestCase(new[] { 1, -2, 3 }, new[] { 0, 0, 0 }, 2, ExpectedResult = 3)]
        [TestCase(new[] { 0, 0 }, new[] { 2, 5, 1, -2, 3 }, 3, ExpectedResult = 303)]
        [TestCase(new[] { 6 }, new[] { 1, -2, 3 }, 2, ExpectedResult = 9)]
        public double MultiplyAndCalculate_ResultOfPolinomialExpression(int[] coefficients1, int[] coefficients2, double variable)
        {
            return (new Polynomial(coefficients1) + new Polynomial(coefficients2)).Calculate(variable);
        }

        [TestCase(new[] { 1, -2, 3 }, new[] { 0, 0, 0 }, ExpectedResult = false)]
        [TestCase(new[] { 0, 0 }, new[] { 2, 5, 1, -2, 3 }, ExpectedResult = false)]
        [TestCase(new[] { 1, -2, 3 }, new[] { 1, -2, 3 }, ExpectedResult = false)]
        public bool OperatorEqual_ComparePolinomialsFalse(int[] coefficients1, int[] coefficients2)
        {
            return new Polynomial(coefficients1) == new Polynomial(coefficients2);
        }

        [TestCase(new[] { 1, -2, 3 }, ExpectedResult = true)]
        [TestCase(new[] { 0, 0 }, ExpectedResult = true)]
        [TestCase(new[] { 1, -2, 3 }, ExpectedResult = true)]
        public bool OperatorEqual_ComparePolinomialsTrue(int[] coefficients)
        {
            var polynomial1 = new Polynomial(coefficients);
            var polynomial2 = polynomial1;
            return polynomial1 == polynomial2;
        }

        [TestCase(new[] { 1, -2, 3 }, new[] { 0, 0, 0 }, ExpectedResult = true)]
        [TestCase(new[] { 0, 0 }, new[] { 2, 5, 1, -2, 3 }, ExpectedResult = true)]
        [TestCase(new[] { 1, -2, 3 }, new[] { 1, -2, 3 }, ExpectedResult = true)]
        public bool OperatorNotEqual_ComparePolinomialsTrue(int[] coefficients1, int[] coefficients2)
        {
            return new Polynomial(coefficients1) != new Polynomial(coefficients2);
        }

        [TestCase(new[] { 1, -2, 3 }, ExpectedResult = false)]
        [TestCase(new[] { 0, 0 }, ExpectedResult = false)]
        [TestCase(new[] { 1, -2, 3 }, ExpectedResult = false)]
        public bool OperatorNotEqual_ComparePolinomialsFalse(int[] coefficients)
        {
            var polynomial1 = new Polynomial(coefficients);
            var polynomial2 = polynomial1;
            return polynomial1 != polynomial2;
        }

        [TestCase(new int[] { })]
        public void Constructor_ThrowsArgumentException(int[] coefficients)
        {
            Assert.Throws<ArgumentException>(() => new Polynomial(coefficients));
        }

        [TestCase()]
        public void Constructor_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Polynomial(null));
        }

        [TestCase(null, null)]
        [TestCase(null, new[] { 1, -2, 3 })]
        [TestCase(new[] { 1, -2, 3 }, null)]
        public void OperatorAdd_ThrowsArgumentNullException(int[] coefficients1, int[] coefficients2)
        {
            Polynomial polynomial1 = null;
            Polynomial polynomial2 = null;
            if (coefficients1 != null)
                polynomial1 = new Polynomial(coefficients1);
            if (coefficients2 != null)
                polynomial2 = new Polynomial(coefficients2);

            Assert.Throws<ArgumentNullException>(() => polynomial1 = polynomial1 + polynomial2);
        }

        [TestCase(null, null)]
        [TestCase(null, new[] { 1, -2, 3 })]
        [TestCase(new[] { 1, -2, 3 }, null)]
        public void OperatorMultiply_ThrowsArgumentNullException(int[] coefficients1, int[] coefficients2)
        {
            Polynomial polynomial1 = null;
            Polynomial polynomial2 = null;
            if (coefficients1 != null)
                polynomial1 = new Polynomial(coefficients1);
            if (coefficients2 != null)
                polynomial2 = new Polynomial(coefficients2);

            Assert.Throws<ArgumentNullException>(() => polynomial1 = polynomial1 * polynomial2);
        }

        [TestCase(new[] { 1, -2, 3 }, null, ExpectedResult = false)]
        [TestCase(new[] { 1, -2, 3 }, new[] { 0, 0, 0 }, ExpectedResult = false)]
        [TestCase(new[] { 0, 0 }, new[] { 2, 5, 1, -2, 3 }, ExpectedResult = false)]
        [TestCase(new[] { 1, -2, 3 }, new[] { 1, -2, 3 }, ExpectedResult = true)]
        public bool Equals_ComparePolinomials(int[] coefficients1, int[] coefficients2)
        {
            Polynomial polynomial1 = null;
            Polynomial polynomial2 = null;
            if (coefficients1 != null)
                polynomial1 = new Polynomial(coefficients1);
            if (coefficients2 != null)
                polynomial2 = new Polynomial(coefficients2);

            return polynomial1.Equals(polynomial2);
        }
    }
}
