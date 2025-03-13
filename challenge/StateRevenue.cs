using System;

public class StateRevenue
{
    public static void Execute()
    {
        double revenueSP = 67836.43;
        double revenueRJ = 36678.66;
        double revenueMG = 29229.88;
        double revenueES = 27165.48;
        double revenueOthers = 19849.53;

        double totalRevenue = revenueSP + revenueRJ + revenueMG + revenueES + revenueOthers;

        double percentageSP = (revenueSP / totalRevenue) * 100;
        double percentageRJ = (revenueRJ / totalRevenue) * 100;
        double percentageMG = (revenueMG / totalRevenue) * 100;
        double percentageES = (revenueES / totalRevenue) * 100;
        double percentageOthers = (revenueOthers / totalRevenue) * 100;

        Console.WriteLine("Revenue percentage of SP: " + percentageSP.ToString("F2") + "%");
        Console.WriteLine("Revenue percentage of RJ: " + percentageRJ.ToString("F2") + "%");
        Console.WriteLine("Revenue percentage of MG: " + percentageMG.ToString("F2") + "%");
        Console.WriteLine("Revenue percentage of ES: " + percentageES.ToString("F2") + "%");
        Console.WriteLine("Revenue percentage of Others: " + percentageOthers.ToString("F2") + "%");
    }
}