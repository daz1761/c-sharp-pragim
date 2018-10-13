using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator.AreEqual(1, 2);

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            // generic call to method
            bool EqualGen = Calculator.AreEqualGen<int>(10, 10);

            if(EqualGen)
            {
                Console.WriteLine("Equal Generic Int");
            }
            else
            {
                Console.WriteLine("Not Equal Generic Int");
            }

            // generic call to class
            bool EqualGenClass = CalculatorGen<int>.AreEqual(1, 1);

            if(EqualGenClass)
            {
                Console.WriteLine("Equal Generic Int Class");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Equal Generic Int Class");
                Console.ReadLine();
            }
        }
    }

    public class Calculator
    {
        // the problem with this is that its tied to an int datatype
        public static bool AreEqual(int Value1, int Value2)
        {
            return Value1 == Value2;
        }

        // we could drop any datatype in this function (System.Object)
        // boxing - because int is a value type and object is a reference type there is a conversion which could cost performance
        // we have lost the strongly typed nature of this method
        public static bool AreEqualObj(object Value1, object Value2)
        {
            return Value1 == Value2;
        }

        // generics is the best way to handle this
        // these are type independent and strongly typed with no boxing
        public static bool AreEqualGen<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }

    // we can make a class generic
    public class CalculatorGen<T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
