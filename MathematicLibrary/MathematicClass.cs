using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicLibrary
{
    
    public class MathematicClass
    {
        /// <summary>
        /// Нахождение суммы двух чисел
        /// </summary>
        /// <param name="x">
        /// Первое число
        /// </param>
        /// <param name="y">
        /// Второе число
        /// </param>
        /// <returns>
        /// Сумма чисел
        /// </returns>
        public static int  Sum(int x, int y)
        {
        return x + y;
        }
        /// <summary>
        /// Нахождение остатка деления
        /// </summary>
        /// <param name="x">
        /// Делимое
        /// </param>
        /// <param name="y">
        /// Делитель
        /// </param>
        /// <returns>
        /// Остаток от деления
        /// </returns>
        public static int Div(int x, int y)
        {
            return x / y;
        }
        
         /// <summary>
        /// Нахождение от умножения
        /// </summary>
        /// <param name="x">
        /// Первое число
        /// </param>
        /// <param name="y">
        /// Второе число
        /// </param>
        /// <returns>
        /// результат
        /// </returns>
        public static int  Mult(int x, int y)
        {
        return x * y;
    }
}
