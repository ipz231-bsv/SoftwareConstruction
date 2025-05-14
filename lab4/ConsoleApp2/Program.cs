namespace ConsoleApp2
{
    public class BasicSupport : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "basic")
            {
                Console.WriteLine("Обробка базового запиту.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }

    public class IntermediateSupport : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "intermediate")
            {
                Console.WriteLine("Обробка запиту середнього рівня.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }

    public class AdvancedSupport : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "advanced")
            {
                Console.WriteLine("Обробка розширеного запиту.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }

    public class ExpertSupport : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "expert")
            {
                Console.WriteLine("Обробка запиту експертного рівня.");
            }
            else
            {
                Console.WriteLine("Невідомий запит. Будь ласка, спробуйте ще раз.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SupportHandler basic = new BasicSupport();
            SupportHandler intermediate = new IntermediateSupport();
            SupportHandler advanced = new AdvancedSupport();
            SupportHandler expert = new ExpertSupport();

            basic.SetNext(intermediate);
            intermediate.SetNext(advanced);
            advanced.SetNext(expert);

            while (true)
            {
                Console.WriteLine("Ласкаво просимо до системи підтримки!");
                Console.WriteLine("Будь ласка, виберіть рівень підтримки:");
                Console.WriteLine("1 - Basic");
                Console.WriteLine("2 - Intermediate");
                Console.WriteLine("3 - Advanced");
                Console.WriteLine("4 - Expert");
                Console.WriteLine("0 - Вийти");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Дякуємо за використання нашої системи підтримки. До побачення!");
                    break;
                }

                bool requestHandled = false;

                switch (choice)
                {
                    case "1":
                        basic.HandleRequest("basic");
                        requestHandled = true;
                        break;
                    case "2":
                        basic.HandleRequest("intermediate");
                        requestHandled = true;
                        break;
                    case "3":
                        basic.HandleRequest("advanced");
                        requestHandled = true;
                        break;
                    case "4":
                        basic.HandleRequest("expert");
                        requestHandled = true;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Будь ласка, спробуйте ще раз.");
                        break;
                }

                if (requestHandled)
                {
                    Console.WriteLine("Запит успішно оброблено.");
                    break;
                }

                Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
                Console.ReadKey();

            }
        }
    }
}
