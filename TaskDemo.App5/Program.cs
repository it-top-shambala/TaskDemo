namespace TaskDemo.App5
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Основная программа запущена");

            var task = new Task<int>(() => TaskExample(5));
            var task2 = task.ContinueWith(PrintResult);
            
            task.Start();
            task2.Wait();

            Console.WriteLine("Основная программа завершена");

            Console.ReadKey();
        }

        private static int TaskExample(int number)
        {
            return number * number;
        }

        private static void PrintResult(Task<int> task)
        {
            Console.WriteLine(task.Result);
        }
    }
}