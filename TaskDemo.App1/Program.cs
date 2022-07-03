namespace TaskDemo.App1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Основная программа запущена");

            var task = Task.Run(TaskExample);
            //task.Wait();
            
            Console.WriteLine("Основная программа завершена");

            Console.ReadKey();
        }

        private static void TaskExample()
        {
            Console.WriteLine("Задача запущена");
            Thread.Sleep(2000);
            Console.WriteLine("Задача завершена");
        }
    }
}