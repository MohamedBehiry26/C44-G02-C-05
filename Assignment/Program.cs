namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
             Passing by Value(Default for Value Types)
                What happens?
A copy of the variable is passed to the method.

Effect:
            Changes made inside the method do not affect the original variable.

🔹 Passing by Reference(using ref or out)
What happens?
A reference to the original variable is passed to the method.

Effect:
            Changes made inside the method do affect the original variable.


            #endregion
        }
    }
}
