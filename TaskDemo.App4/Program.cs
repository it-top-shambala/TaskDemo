namespace TaskDemo.App4
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const int NUMBER = 15;
            Console.WriteLine("Основная программа запущена");
            
            var task = new Task<int>(() => Factorial(NUMBER));
            task.Start();
            var factorial = task.Result;
            Console.WriteLine($"{NUMBER}! = {factorial}");

            Console.WriteLine("Основная программа завершена");

            Console.ReadKey();
        }

        private static int Factorial(int number)
        {
            int res = 1;
            for (int i = 1; i <= number; i++)
            {
                res *= i;
                Console.WriteLine($"{i}! = {res}");
            }
            return res;
        }
    }
}