using System;
using System.Linq;

public class LotteryGame
{
    private const int NumberCount = 6;
    private const int Min = 1;
    private const int Max = 49;

    public int[] UserNumbers { get; private set; }
    public int[] WinningNumbers { get; private set; }

    private Random random = new Random();

    // Получение чисел пользователя
    public void EnterUserNumbers()
    {
        UserNumbers = new int[NumberCount];

        Console.WriteLine("Введите 6 чисел от 1 до 49:");

        for (int i = 0; i < NumberCount; i++)
        {
            int number;
            while (true)
            {
                Console.Write($"Число {i + 1}: ");

                if (int.TryParse(Console.ReadLine(), out number) &&
                    number >= Min &&
                    number <= Max &&
                    !UserNumbers.Contains(number))
                {
                    UserNumbers[i] = number;
                    break;
                }

                Console.WriteLine("Ошибка. Введите уникальное число от 1 до 49.");
            }
        }
    }

    // Генерация выигрышных номеров
    public void GenerateWinningNumbers()
    {
        WinningNumbers = new int[NumberCount];

        for (int i = 0; i < NumberCount; i++)
        {
            int num;
            do
            {
                num = random.Next(Min, Max + 1);
            } while (WinningNumbers.Contains(num));

            WinningNumbers[i] = num;
        }
    }

    // Подсчёт совпадений
    public int GetMatches()
    {
        return UserNumbers.Intersect(WinningNumbers).Count();
    }
}
