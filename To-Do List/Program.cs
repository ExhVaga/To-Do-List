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

        static void ShowTasks()
        {
            if( tasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст.");
            }
            else
            {
                Console.WriteLine("Спискок задач:");
                for(int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {tasks[i]}");
                }
            }
        }
    }
}
