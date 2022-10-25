namespace Calculator
{
    class Calculator
    {
        
        static void Main()
        {
            Input();
            Exit();
        }
        static void Input()
        {

            Console.WriteLine("a =: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b =: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Виберіть дію(+, -, * або /)");
            string action = Console.ReadLine();
            Console.WriteLine("Бажаєне зняти ліміт?(y або n):");
            string limit = Console.ReadLine();
            if(limit == "y")
            {
                Unlimit(a,b,action);
            }
            else
            {
                Limit_Action(action, a, b);
            }

        }
        static void Limit_Action(string action, int a, int b)
        {
            int c;
            switch (action)
            {
                case "+":
                    c = a + b;
                    Limit(c,a,b,action);
                    break;
                case "-":
                    c = a - b;
                    Limit(c, a, b, action);
                    break;
                case "*":
                    c = a * b;
                    Limit(c, a, b, action);
                    break;
                case "/":
                    c = a / b;
                    Limit(c, a, b, action);
                    break;
                default: Console.WriteLine("Сталась помилка! Спробуйте знову.");
                    break;

            }
        }
        static void Unlimit_Action(string action, int a, int b)
        {
            int c;
            switch (action)
            {
                case "+":
                    c = a + b;
                    Console.WriteLine(c);
                    break;
                case "-":
                    c = a - b;
                    Console.WriteLine(c);
                    break;
                case "*":
                    c = a * b;
                    Console.WriteLine(c);
                    break;
                case "/":
                    c = a / b;
                    Console.WriteLine(c);
                    break;
                default:
                    Console.WriteLine("Сталась помилка! Спробуйте знову.");
                    break;

            }
        }
        static void Limit(int c,int a,int b, string action)
        {
            if (c > 10)
            {
                Console.WriteLine("Перевищено ліміт. Для зняття підключіть файл-ключ(команда - unlimit) або почніть з початку(start).");
                string command = Console.ReadLine();
                if(command == "unlimit")
                {
                    Unlimit(a,b,action);
                }else if(command == "start"){
                    Input();
                }else
                {
                    Console.WriteLine("Неправильна команда. Спробуйте знову.");
                    Limit(c,a,b,action);
                }
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        static void Unlimit(int a, int b, string action)
        {
                Console.WriteLine("Введіть шлях до фалу: ");
                string file = Console.ReadLine();
                
                if (File.Exists(file))
                {
                    string fileText = File.ReadAllText(file);
                    if(fileText == "Unlock")
                    {
                        Unlimit_Action(action,a,b);
                    }
                }
                else
                {
                    Console.WriteLine("Файла не існує.");
                    Unlimit(a,b,action);
                }
        }
        static void Exit()
        {
            Console.WriteLine("Exit?(y or n):");
            string exit = Console.ReadLine();
            if(exit == "y")
            {
                return;
            }
            else
            {
                Input();
            }
        }
    }
}







