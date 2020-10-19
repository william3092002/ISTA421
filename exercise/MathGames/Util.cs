using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ex_12_william
{
    public class Util
    {
        static Random randNum = new Random();
        public static int Add(double numProb)
        {
            int totalScore = 0;
            for (int i = 0; i < numProb; i++)
            {
                int operand1 = randNum.Next(13);
                int operand2 = randNum.Next(13);
                Console.Write($"{i+1}. {operand1} + {operand2} = ");
                int userInput = int.Parse(Console.ReadLine());
                if(userInput == operand1 + operand2)
                {
                    Console.WriteLine("Correct.");
                    totalScore++;
                }
                else
                    Console.WriteLine($"Sorry, the correct answer is {operand1 + operand2}");
            }
            return totalScore;
        }

        public static int Subtract(double numProb)
        {
            int totalScore = 0;
            for (int i = 0; i < numProb; i++)
            {
                double operand1 = randNum.Next(13);
                double operand2 = randNum.Next(13);
                double firstOperand = 0;
                double secondOperand = 0;
                if (operand1 > operand2)
                {
                    firstOperand = operand1;
                    secondOperand = operand2;
                }
                else if(operand2 > operand1)
                {
                    firstOperand = operand2;
                    secondOperand = operand1;
                }
                else
                {
                    firstOperand = operand1;
                    secondOperand = operand2;
                }
                Console.WriteLine($"{i + 1}. {firstOperand} - {secondOperand} = ");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 
                   Math.Round((firstOperand-secondOperand),2))
                {
                    Console.WriteLine("Correct.");
                    totalScore++;
                }
                else
                    Console.WriteLine($"Sorry, the correct answer is {firstOperand-secondOperand}");
            }
            return totalScore;
        }
        public static int Multiply (double numProb)
        {
            int totalScore = 0;
            for (int i = 0; i < numProb; i++)
            {
                int operand1 = randNum.Next(13);
                int operand2 = randNum.Next(13);
                Console.Write($"{i + 1}. {operand1} * {operand2} = ");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == operand1 * operand2)
                {
                    Console.WriteLine("Correct.");
                    totalScore++;
                }
                else
                    Console.WriteLine($"Sorry, the correct answer is {operand1 * operand2}");
            }
            return totalScore;
        }

        public static int Divide(double numProb)
        {
            int totalScore = 0;
            for (int i = 0; i < numProb; i++)
            {
                double operand1 = randNum.Next(13);
                double operand2 = randNum.Next(1,13);
                Console.Write($"{i + 1}. {operand1} / {operand2} = ");
                double userInput = double.Parse(Console.ReadLine());
                if (userInput == Math.Round((operand1/operand2),2) | userInput == Math.Round((operand1 / operand2),3))
                {
                    Console.WriteLine("Correct.");
                    totalScore++;
                }
                else
                    Console.WriteLine($"Sorry, the correct answer is {Math.Round((operand1/operand2),2)}");
            }
            return totalScore;
        }
    }
}
