using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // броя на хората в журито
            string presentation = Console.ReadLine();
            double middleSumGrade = 0;
            int numPresentations = 0;

            while (presentation != "Finish")
            {
                numPresentations++;
                double gradeSum = 0;
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;

                }
                double middleGrade = gradeSum / n;
                middleSumGrade += middleGrade;
                Console.WriteLine($"{presentation} - {middleGrade:F2}.");
                
                presentation = Console.ReadLine();
            }
            double finalGrade = middleSumGrade / numPresentations;
            Console.WriteLine($"Student's final assessment is {finalGrade:F2}.");
        }
    }
}
