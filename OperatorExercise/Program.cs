namespace OperatorExercise
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a = 100;
            int b = 2;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % ++b);

            Console.WriteLine("Please input a number to be used as the radius.");
            double o = double.Parse(Console.ReadLine());
            Console.WriteLine(Circle.AreaOfCircle(o));
        }
    }
}




//public static int Add(params int[] numbers)
//    {
//        int add = 0;
//        foreach (int num in numbers) { add += num; }
//        return add;
//    }
//public static int Subtract(int initial, params int [] numbers)
//    {
//        int subtract = initial;
//        foreach (int num in numbers) { subtract -= num; }
//        return subtract;
//    }
//    public static int Mulitply(int initial, params int[] numbers)
//    {
//        int multiply = initial;
//        foreach (int num in numbers) { multiply *= num; }
//        return multiply; 
//    }
//    public static int Divide(int intitial, params int[] numbers)
//    {
//        int divide = intitial;
//        foreach (int num in numbers) { divide /= num; }
//        return divide;
//    }
