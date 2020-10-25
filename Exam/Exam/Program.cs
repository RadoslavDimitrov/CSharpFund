using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinNum = int.Parse(Console.ReadLine());
            double yuanNum = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            //•	1 биткойн = 1168 лева.
            //•	1 китайски юан = 0.15 долара.
            //•	1 долар = 1.76 лева.
            //•	1 евро = 1.95 лева.

            //all in euro :F2

            int bitcointInLv = bitcoinNum * 1168;
            double bitcoinInEur = bitcointInLv / 1.95;

            double yuanInUsd = yuanNum * 0.15;
            double yuanInLv = yuanInUsd * 1.76;
            double yuanInEur = yuanInLv / 1.95;

            double sum = yuanInEur + bitcoinInEur;
            double sumWithCommision = sum - (sum * (commision / 100));
            Console.WriteLine($"{sumWithCommision:F2}");


        }
    }
}
