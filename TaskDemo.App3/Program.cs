namespace TaskDemo.App3
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
                var x = i;
                tasks[i] = new Task(() => TaskExample(x + 1));
            }
            
            for (int i = 0; i < SIZE; i++)
            {
                tasks[i].Start();
                //Thread.Sleep(1);
            }

            //Task.WaitAll(tasks);
            Task.WaitAny(tasks);
            
            Console.WriteLine("Основная программа завершена");

            //Console.ReadKey();
        }

        private static void TaskExample(int i)
        {
            Console.WriteLine($"#{i} задача запущена");
            Thread.Sleep(2000);
            Console.WriteLine($"#{i} задача завершена");
        }
    }
}