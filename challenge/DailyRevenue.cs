using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

public class DailyRevenue
{
    public static void Execute()
    {
        string json = File.ReadAllText("revenue.json");
        var revenueData = JsonConvert.DeserializeObject<RevenueData[]>(json);

        if (revenueData == null || revenueData.Length == 0)
        {
            Console.WriteLine("Error: Revenue data could not be loaded.");
            return;
        }

        var dailyRevenue = revenueData
            .Where(data => data.Valor > 0)
            .Select(data => data.Valor)
            .ToArray();

        if (dailyRevenue.Length == 0)
        {
            Console.WriteLine("No days with revenue.");
            return;
        }

        double lowestRevenue = dailyRevenue.Min();
        double highestRevenue = dailyRevenue.Max();
        double totalRevenue = dailyRevenue.Sum();
        int daysWithRevenue = dailyRevenue.Length;

        double monthlyAverage = totalRevenue / daysWithRevenue;
        int daysAboveAverage = dailyRevenue.Count(revenue => revenue > monthlyAverage);

        Console.WriteLine("Lowest daily revenue: " + lowestRevenue);
        Console.WriteLine("Highest daily revenue: " + highestRevenue);
        Console.WriteLine("Number of days with revenue above the monthly average: " + daysAboveAverage);
    }
}

public class RevenueData
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}