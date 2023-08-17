
namespace T09_02_Methods
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y)
        {
            // Console.WriteLine($"The value of {x} + {y} = {x + y}.");
            return x + y;
        }

        public static void AddAll(double[] values)
        {
            double result = 0;

            foreach (var value in values)
            {
                result += value;
            }

            Console.WriteLine($"The total is {result}.");
        }
    }
}
