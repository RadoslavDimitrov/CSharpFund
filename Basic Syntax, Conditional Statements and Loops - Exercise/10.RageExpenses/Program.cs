using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	On the first input line - lost games count – integer in the range[0, 1000].
            //•	On the second line – headset price -floating point number in range[0, 1000].
            //•	On the third line – mouse price -floating point number in range[0, 1000].
            //•	On the fourth line – keyboard price -floating point number in range[0, 1000].
            //•	On the fifth line – display price -floating point number in range[0, 1000].

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            //Every second lost game, Pesho trashes his headset.
            //Every third lost game, Pesho trashes his mouse.
            //When Pesho trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.

            double totalMoney = 0;
            int keyboardCrashed = 0;

            for (int i = 0; i < lostGames; i++)
            {
                if(i % 2 == 0 && i != 0)
                {
                    totalMoney += headsetPrice;
                }
                if(i % 3 == 0 && i != 0)
                {
                    totalMoney += mousePrice;
                }
                if(i % 2 == 0 && i % 3 == 0 && i != 0)
                {
                    totalMoney += keyboardPrice;
                    keyboardCrashed++;
                    if (keyboardCrashed % 2 == 0)
                    {
                        totalMoney += displayPrice;
                        keyboardCrashed = 0;
                    }
                   

                }
            }

            Console.WriteLine($"Rage expenses: {totalMoney:F2} lv.");

        }
    }
}
