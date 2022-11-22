
namespace MethodsExercise
{
    internal class Exercise_2
    {
        public static int Add(int num1, int num2)
        { return num1 + num2; }

        public static int Subtract(int num1, int num2)
        { return num1 - num2; }

        public static int Multiply(int num1, int num2)
        { return num1 * num2; }

        public static int Divide(int num1, int num2)
        { return num1 / num2; }

        public static int Modulus(int num1, int num2)
        { return num1 % num2; }

    }
}

    internal class UsingParams
    {
        public static void Params(params int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " "); 
        }

        Console.WriteLine();
    }
    }
