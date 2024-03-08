namespace _100daycoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(12.39816); //double
            Console.WriteLine(1_200_000_000_000.39816m); //decimal
            Console.WriteLine(12.39816f); //float
            //----boolean----//
            Console.WriteLine(true);
            Console.WriteLine(false);

            //-----var-----//
            var message = "hello world";
            Console.WriteLine(34.40M);
            //-----string----//
            string firstName = "Bob";
            string message2 = $"Hello {firstName}!";
            Console.WriteLine(message2);
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
            //-------math_operators-------//
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            decimal quotient = 7 / 5.0m;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            int first = 7;
            int second = 5;
            decimal quotient1 = (decimal)first / (decimal)second;
            Console.WriteLine(quotient1);

        }
    }
}
