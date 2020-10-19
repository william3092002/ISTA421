using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_12_william
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math Game");
            int probType = 0;
            double numProb = 0;
            double score = 0.0;
            Console.WriteLine("What type of test do you want to take?\n" +
                "1: addition\n" +
                "2: subtraction\n" +
                "3: multiplication\n" +
                "4: division");
            probType = int.Parse(Console.ReadLine());
            Console.WriteLine("How many questions do you want to answer?");
            switch (probType)
            {
                case 1:
                    numProb = int.Parse(Console.ReadLine());
                    score = Util.Add(numProb);
                    break;
                case 2:
                    numProb = int.Parse(Console.ReadLine());
                    score = Util.Subtract(numProb);
                    break;
                case 3:
                    numProb = int.Parse(Console.ReadLine());
                    score = Util.Multiply(numProb);
                    break;
                case 4:
                    numProb = int.Parse(Console.ReadLine());
                    score = Util.Divide(numProb);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"You got {score} out of {numProb} correct and your grade is {Math.Round((score/numProb*100),2)}");
        }

    }
}
