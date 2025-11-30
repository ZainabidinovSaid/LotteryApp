using System;
using System.IO;

public class StatisticsManager
{
    private const string FilePath = "results.txt";

    public void SaveResult(int[] userNums, int[] winningNums, int matches)
    {
        using (StreamWriter sw = new StreamWriter(FilePath, true))
        {
            sw.WriteLine("---- Новая игра ----");
            sw.WriteLine("Выбор пользователя: " + string.Join(", ", userNums));
            sw.WriteLine("Выигрышные номера:  " + string.Join(", ", winningNums));
            sw.WriteLine("Совпадений: " + matches);
            sw.WriteLine("Дата: " + DateTime.Now);
            sw.WriteLine();
        }
    }

    public void ShowStatistics()
    {
        if (!File.Exists(FilePath))
        {
            Console.WriteLine("Статистика отсутствует.");
            return;
        }

        string text = File.ReadAllText(FilePath);
        Console.WriteLine("\n=== Статистика игр ===\n");
        Console.WriteLine(text);
    }
}
