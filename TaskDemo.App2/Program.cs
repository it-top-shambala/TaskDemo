namespace TaskDemo.App2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const int SIZE = 10;
            var tasks = new Task[SIZE];
            
            Console.WriteLine("Основная программа запущена");

            for (int i = 0; i < SIZE; i++)
            {
                tasks[i] = new Task(TaskExample);
            }
            
            for (int i = 0; i < SIZE; i++)
            {
                tasks[i].Start();
            }

            Task.WaitAll(tasks);
            
            Console.WriteLine("Основная программа завершена");

            //Console.ReadKey();
        }

        private static void TaskExample()
        {
            Console.WriteLine("Задача запущена");
            Thread.Sleep(2000);
            Console.WriteLine("Задача завершена");
        }
    }
}