using System;

class Program
{
    static void Main()
    {
        StatisticsManager stats = new StatisticsManager();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Lottery Number Simulator =====");
            Console.WriteLine("1. Сыграть");
            Console.WriteLine("2. Посмотреть статистику");
            Console.WriteLine("3. Выход");
            Console.Write("Выберите опцию: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                LotteryGame game = new LotteryGame();

                game.EnterUserNumbers();
                game.GenerateWinningNumbers();

                int matches = game.GetMatches();

                Console.WriteLine("\nВаши числа:       " + string.Join(", ", game.UserNumbers));
                Console.WriteLine("Выигрышные числа: " + string.Join(", ", game.WinningNumbers));
                Console.WriteLine("Совпадений: " + matches);

                stats.SaveResult(game.UserNumbers, game.WinningNumbers, matches);

                Console.WriteLine("\nРезультат сохранен. Нажмите Enter.");
                Console.ReadLine();
            }
            else if (input == "2")
            {
                Console.Clear();
                stats.ShowStatistics();
                Console.WriteLine("\nНажмите Enter.");
                Console.ReadLine();
            }
            else if (input == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Неправильный ввод. Нажмите Enter.");
                Console.ReadLine();
            }
        }
    }
}
