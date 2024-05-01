namespace To_Do_List
{
    internal class Program  
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("1. Добавить новую задачу");
                Console.WriteLine("2. Показать список всех задач");
                Console.WriteLine("3. Удалить задачу");
                Console.WriteLine("4. Выход \n");
                Console.WriteLine("Выберите действие: ");

                string choice = Console.ReadLine();

                switch( choice)
                {
                    case "1":
                        AddTask(); 
                        break;

                    case "2":
                        ShowTasks();
                        break;

                    case "3":
                        RemoveTask(); 
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                }

                Console.WriteLine();

            }
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

        static void RemoveTask()
        {
            ShowTasks();
            if( tasks.Count == 0)
            {
                return;
            }

            if ( int.TryParse(Console.ReadLine(), out int index ) && index >= 1 && index <= tasks.Count )
            {
                Console.WriteLine("Введите номер удаляемой задачи: ");
                tasks.RemoveAt( index - 1 );
                Console.WriteLine($"Задача под номером {index - 1} была успешно удалена.");
            }
            else
            {
                Console.WriteLine("Введен неверный номер задачи.");
            }
        }
    }
}
