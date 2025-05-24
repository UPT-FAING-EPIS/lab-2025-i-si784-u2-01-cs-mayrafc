using System;

namespace Math.Lib
{
    /// <summary>
    /// Proporciona métodos matemáticos personalizados.
    /// </summary>
    public class Rooter
    {
        /// <summary>
        /// Calcula la raíz cuadrada de un número positivo utilizando el método de Newton-Raphson.
        /// </summary>
        /// <param name="input">Número positivo del que se desea calcular la raíz cuadrada.</param>
        /// <returns>Raíz cuadrada aproximada del número proporcionado.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Se lanza si el número ingresado es cero o negativo.
        /// </exception>
        public double SquareRoot(double input)
        {
            if (input <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(input), "El valor ingresado es invalido, solo se puede ingresar números positivos.");

            double result = input;
            double previousResult = -input;

            while (System.Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result
