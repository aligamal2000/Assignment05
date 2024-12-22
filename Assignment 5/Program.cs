using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Assignment_5
{
    #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
    /* 1-Passing by Value:When a value type is passed by value, a copy of the value is passed to the method. Changes made to the parameter inside the method do not affect the original variable outside the method.
       2-Passing by Reference: When a value type is passed by reference using the ref or out keyword, the method operates on the original variable. Changes made to the parameter inside the method are reflected outside the method.
*/
    internal class Program
    {

        //value Type Parameters[Passing By Ref]
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //static void Main()
        //{
        //    int A = 9, B = 4;
        //    Console.WriteLine(A); // 9
        //    Console.WriteLine(B); // 4
        //    SWAP(ref A, ref B);
        //    Console.WriteLine(A); // 4
        //    Console.WriteLine(B); // 9
        //}


        // Value Type Parameters[Passing By Value]
        //public static void SWAP(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //static void Main()
        //{
        //    int A = 9, B = 4;
        //    Console.WriteLine(A); // 9
        //    Console.WriteLine(B); // 4
        //    SWAP(A, B);
        //    Console.WriteLine(A);
        //    Console.WriteLine(B);
        //}
        #endregion

        #region 2-Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
        /*
          Passing Reference Type by Value:
        When a reference type is passed by value  the method receives a copy of the reference (not the object itself). The method can modify the properties of the object that the reference points to, but it cannot reassign the reference itself to a new object. Changes to the reference itself are not reflected outside the method.
        Passing Reference Type by Reference:
        When a reference type is passed by reference using the ref keyword, the method operates on the original reference. This means the method can modify the properties of the object and also reassign the reference to point to a new object, and these changes are reflected outside the method.
        */
        //1-Reference Type Parameters[Passing By Value]

        //public static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}
        //static void Main()
        //{
        //    int[] Numbers = { 1, 2, 3 }; Console.WriteLine(SumArray(Numbers));
        //    Console.WriteLine(Numbers[0]);
        //}


        //2- Reference Type Parameters[Passing By Ref]

        //public static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}
        //static void Main()
        //{
        //    int[] Numbers = { 1, 2, 3 }; Console.WriteLine(SumArray(ref Numbers));
        //    Console.WriteLine(Numbers[0]);
        //}









        #endregion


        #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers



        //public static int ParseInput(string? input)
        //{
        //    if (int.TryParse(input, out int result))
        //    {
        //        return result;
        //    }
        //    Console.WriteLine("Invalid input. Defaulting to 0.");
        //    return 0;
        //}

        //public static (int sum, int difference) Calculate(int a, int b, int c, int d)
        //{
        //    int sum = a + b;
        //    int difference = c - d;
        //    return (sum, difference);
        //}


        //static void Main(string[] args)
        //{
        //    Console.Write("Enter first number: ");
        //    int num1 = ParseInput(Console.ReadLine());

        //    Console.Write("Enter second number: ");
        //    int num2 = ParseInput(Console.ReadLine());

        //    Console.Write("Enter third number: ");
        //    int num3 = ParseInput(Console.ReadLine());

        //    Console.Write("Enter fourth number: ");
        //    int num4 = ParseInput(Console.ReadLine());

        //    (int sum, int difference) = Calculate(num1, num2, num3, num4);

        //    Console.WriteLine($"Summation Result: {sum}");
        //    Console.WriteLine($"Subtraction Result: {difference}");
        //}




        #endregion

        #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.   Output should be like Enter a number: 25     The sum of the digits of the number 25 is: 7




        //public  static int SumOfDigits(int num)
        //  {
        //      int sum = 0;
        //      num = Math.Abs(num);
        //      while (num > 0)
        //      {
        //          sum += num % 10;
        //          num /= 10;
        //      }
        //      return sum;
        //  }

        //  static void Main(string[] args)
        //  {
        //      Console.Write("Enter a number: ");
        //      string? input = Console.ReadLine(); // Allow null

        //      if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int number))
        //      {
        //          int sum = SumOfDigits(number);
        //          Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
        //      }
        //      else
        //      {
        //          Console.WriteLine("Invalid input. Please enter a valid integer.");
        //      }
        //  }






        // i removed the warning:Converting null literal or possible null value to non-nullable type.

        #endregion
        #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:




        //public static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false; 
        //    if (number == 2) return true; 

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false; 
        //        }
        //    }

        //    return true; 
        //}



        //static void Main(string[] args)
        //{
        //    Console.Write("Enter a number: ");
        //    string? input = Console.ReadLine();

        //    if (int.TryParse(input, out int number))
        //    {
        //        bool isPrime = IsPrime(number);
        //        Console.WriteLine(isPrime
        //            ? $"{number} is a prime number."
        //            : $"{number} is not a prime number.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid integer.");
        //    }
        //}
        //Enter a number: 5 :5 is a prime number.
        //Enter a number: 10 :10 is not a prime number.

        #endregion
        #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters




        //public  static void MinMaxArray(int[] array, ref int min, ref int max)
        //  {
        //      if (array == null || array.Length == 0)
        //      {
        //          throw new ArgumentException("Array must not be null or empty.");
        //      }

        //      min = array[0];
        //      max = array[0];


        //      foreach (int number in array)
        //      {
        //          if (number < min) min = number;
        //          if (number > max) max = number;
        //      }
        //  }
        //  static void Main(string[] args)
        //  {
        //      int[] numbers = { 7, 2, 10, 4, 8 };


        //      int min = 0, max = 0;


        //      MinMaxArray(numbers, ref min, ref max);

        //      Console.WriteLine($"Minimum value: {min}");
        //      Console.WriteLine($"Maximum value: {max}");
        //  }



        #endregion
        #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter


        //public static long CalculateFactorial(int number)
        // {
        //     long result = 1; // Initialize with 1, as factorial of 0 is 1

        //     for (int i = 1; i <= number; i++)
        //     {
        //         result *= i; // Multiply result by the current number
        //     }

        //     return result;
        // }

        // static void Main(string[] args)
        // {
        //     Console.Write("Enter a number: ");
        //     string? input = Console.ReadLine();

        //     if (int.TryParse(input, out int number) && number >= 0)
        //     {
        //         long factorial = CalculateFactorial(number);
        //         Console.WriteLine($"The factorial of {number} is: {factorial}");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        //     }
        // }

        #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

       public static string ChangeChar(string input, int position, char newChar)
        {
            if (position < 0 || position >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            }

            char[] chars = input.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string? input = Console.ReadLine();

            Console.Write("Enter the position to modify (0-based): ");
            string? positionInput = Console.ReadLine();

            Console.Write("Enter the new character: ");
            string? charInput = Console.ReadLine();

            if (input != null &&
                int.TryParse(positionInput, out int position) &&
                charInput != null &&
                charInput.Length == 1)
            {
                char newChar = charInput[0];
                try
                {
                    string modifiedString = ChangeChar(input, position, newChar);
                    Console.WriteLine($"Modified string: {modifiedString}");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Position is out of range.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please ensure the inputs are valid.");
            }
        }

 
    

    #endregion


    #endregion

}

}
