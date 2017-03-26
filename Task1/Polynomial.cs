using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Represents immutable class for working with polynomials
    /// </summary>
    public class Polynomial
    {
        /// <summary>
        /// Array with polynomial's coefficients
        /// </summary>
        private readonly int[] _coefficients;

        /// <summary>
        /// Gets polynomial's coefficients
        /// </summary>
        public int[] Coefficients
        {
            get
            {
                int[] coefficients = new int[_coefficients.Length];
                _coefficients.CopyTo(coefficients, 0);
                return coefficients;
            }
        }

        /// <summary>
        /// Creates new Polynomial object with given coefficients
        /// </summary>
        /// <param name="coefficients">Polynomial's coefficients</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Polynomial(int[] coefficients)
        {
            if (coefficients == null)
                throw new ArgumentNullException();

            if(!coefficients.Any())
                throw new ArgumentException();

            _coefficients = new int[coefficients.Length];
            coefficients.CopyTo(_coefficients, 0);
        }

        #region Overloaded Operations

        /// <summary>
        /// Adds two polynomials
        /// </summary>
        /// <param name="polynomial1">First polynomial</param>
        /// <param name="polynomial2">Second polynomial</param>
        /// <returns>Sum of polynomials</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Polynomial operator +(Polynomial polynomial1, Polynomial polynomial2)
        {
            if (polynomial1 == null || polynomial2 == null)
                throw new ArgumentNullException();

            int[] coefficients = new int[polynomial1.Coefficients.Length > polynomial2.Coefficients.Length
                ? polynomial1.Coefficients.Length : polynomial2.Coefficients.Length];

            (polynomial1.Coefficients.Length > polynomial2.Coefficients.Length
                ? polynomial1.Coefficients : polynomial2.Coefficients).CopyTo(coefficients, 0);

            for (int i = polynomial1.Coefficients.Length <= polynomial2.Coefficients.Length
                        ? polynomial1.Coefficients.Length - 1
                        : polynomial2.Coefficients.Length - 1,
                    j = coefficients.Length - 1;
                i >= 0;
                i--, j--)
            {
                coefficients[j] += polynomial1.Coefficients.Length <= polynomial2.Coefficients.Length
                    ? polynomial1.Coefficients[i]
                    : polynomial2.Coefficients[i];
            }

            return new Polynomial(coefficients);
        }

        /// <summary>
        /// Finds the substraction of two polynomials
        /// </summary>
        /// <param name="polynomial1">First polynomial</param>
        /// <param name="polynomial2">Second polynomial</param>
        /// <returns>Substraction of polynomials</returns>
        public static Polynomial operator -(Polynomial polynomial1, Polynomial polynomial2)
        {
            return polynomial1 + (-polynomial2);
        }

        /// <summary>
        /// Inverts coefficients of the polynomial
        /// </summary>
        /// <param name="polynomial">Source polynomial</param>
        /// <returns>Polynomial with inverted coefficients</returns>
        public static Polynomial operator -(Polynomial polynomial)
        {
            int[] coefficients = new int[polynomial.Coefficients.Length];

            for (int i = 0; i < coefficients.Length; i++)
                coefficients[i] = -polynomial.Coefficients[i];

            return new Polynomial(coefficients);
        }

        /// <summary>
        /// Mutliplies two polynomials
        /// </summary>
        /// <param name="polynomial1">First polynomial</param>
        /// <param name="polynomial2">Second polynomial</param>
        /// <returns>Multiplication of polynoms</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Polynomial operator *(Polynomial polynomial1, Polynomial polynomial2)
        {
            if (polynomial1 == null || polynomial2 == null)
                throw new ArgumentNullException();

            int[] coefficients = new int[polynomial1.Coefficients.Length + polynomial2.Coefficients.Length - 1];

            for (int i = polynomial1.Coefficients.Length - 1; i >= 0; i--)
            {
                for (int j = polynomial2.Coefficients.Length - 1; j >= 0; j--)
                {
                    coefficients[j + j] = polynomial1.Coefficients[i] * polynomial2.Coefficients[j];
                }
            }

            return new Polynomial(coefficients);
        }

        /// <summary>
        /// Compares two Polynomial variables
        /// </summary>
        /// <param name="polynomial1">First Polynomial variable</param>
        /// <param name="polynomial2">Second Polynomial variable</param>
        /// <returns>Result of comparison: true if variables are equal, false if they are not</returns>
        public static bool operator ==(Polynomial polynomial1, Polynomial polynomial2)
        {
            return ReferenceEquals(polynomial1, polynomial2);
        }

        /// <summary>
        /// Compares two Polynomial variables
        /// </summary>
        /// <param name="polynomial1">First Polynomial variable</param>
        /// <param name="polynomial2">Second Polynomial variable</param>
        /// <returns>Result of comparison: true if variables are not equal, false if the are</returns>
        public static bool operator !=(Polynomial polynomial1, Polynomial polynomial2)
        {
            return !(polynomial1 == polynomial2);
        }

        #endregion

        #region Overrided Object Methods

        /// <summary>
        /// Determines whether the specified object is equal to the current Polynomial object
        /// </summary>
        /// <param name="obj">The object to compare with the current Polynomial object</param>
        /// <returns>True if the specified object is equal to the current Polynomial object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
            return Equals(obj as Polynomial);
        }

        /// <summary>
        /// Determines whether the specified Polynomial object is equal to the current Polynomial object
        /// </summary>
        /// <param name="polynomial">The Polynomial object to compare with the current Polynomial object</param>
        /// <returns>True if the specified Polynomial object is equal to the current Polynomial object; otherwise, false</returns>
        public bool Equals(Polynomial polynomial)
        {
            if (polynomial == null)
                return false;

            if (ReferenceEquals(this, polynomial))
                return true;

            if (polynomial.Coefficients.Length != _coefficients.Length)
                return false;

            for (int i = 0; i < _coefficients.Length; i++)
            {
                if (_coefficients[i] != polynomial.Coefficients[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Serves as the default hash function
        /// </summary>
        /// <returns>Hash code of the Polynomial object</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        /// <summary>
        /// Calculates the result of the expression for the specified variable
        /// </summary>
        /// <param name="variable">Variable to calculate the result of the polynomial expression for</param>
        /// <returns>The result og the expression</returns>
        public double Calculate(double variable)
        {
            double result = 0;

            for (int i = 0; i < _coefficients.Length; i++)
                result += _coefficients[i] * Math.Pow(variable, _coefficients.Length - i - 1);

            return result;
        }
    }
}
