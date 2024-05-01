namespace To_Do_List
{
    internal class Program  
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            AddTask();
        }

        static void AddTask()
        {
            Console.WriteLine("Введите новую задачу: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Задача добавлена успешно!");
        }
    }
}
