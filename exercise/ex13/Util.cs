using System;
using System.Collections.Generic;

namespace ex13_william
{
    class Util
    {
        static int questionCounter = 1;
        static Dictionary<int, string> userAnswer = new Dictionary<int, string>();

        public static void PrintQuestions(int questionNumber)
        {
            Console.WriteLine($"\n{questionCounter}. {Initialize.Questions[questionNumber]}");
            questionCounter++;
            PrintSeperator(Initialize.Questions[questionNumber].Length, '-');

            List<int> numAGenerated = new List<int>();

            for (int i = 0; i < 4; i++)
                numAGenerated.Add(i);
            int answerNumber = 0;
            for (int i = 0; i < 4; i++)
            {
                if (numAGenerated.Count != 1)
                    answerNumber = numAGenerated[testGenerator.Next(numAGenerated.Count)];
                else
                    answerNumber = numAGenerated[0];
                userAnswer.Add(i, Initialize.AnswerKeys[questionNumber, answerNumber]);
                Console.WriteLine($"{i + 1}: \"{Initialize.AnswerKeys[questionNumber, answerNumber]}\"");
                numAGenerated.Remove(answerNumber);
            }
            PrintSeperator(Initialize.Questions[questionNumber].Length, '-');
        }
        
        public static void PrintSeperator(int length, char symbol)
        {
            for (int i = 0; i < length + 3; i++)
                Console.Write(symbol);
            Console.WriteLine();
        }

        static double numCorrectA = 0.0;
        public static void CheckInput(int questionNumber, int inputAnswer)
        {
            if ( userAnswer[inputAnswer - 1] != Initialize.FinalTestBank[Initialize.Questions[questionNumber]])
                Console.WriteLine($"\nSorry, the correct answer is \"{Initialize.FinalTestBank[Initialize.Questions[questionNumber]]}\"");
            else
            {
                Console.WriteLine("\nCorrect. Good job!");
                numCorrectA++;
            }
        }

        static int userInputCounter;
        static int answerInputResult;
        public static void GetUserInput()
        {
            do
            {
                try
                {
                    userInputCounter = 0;
                    int result = int.Parse(Console.ReadLine());
                    if (result <= 4 & result >= 1)
                        answerInputResult = result;
                    else
                        throw new OperationCanceledException("Please enter a number between 1 to 4");
                    
                }
                catch (OperationCanceledException oCe)
                {
                    Console.WriteLine(oCe.Message);
                    userInputCounter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number between 1 to 4");
                    userInputCounter++;
                }

            } while (userInputCounter != 0);
            
        }
        static void CalculateScore()
        {
            double result = numCorrectA / numOfQuestions * 100.00;
            string sResult = $"You answerd {numCorrectA} out of {numOfQuestions} correctly and your grade is {result}";
            Console.WriteLine();
            PrintSeperator(sResult.Length-3, '=');
            Console.WriteLine(sResult);
            PrintSeperator(sResult.Length-3, '=');
        }
        static Random testGenerator = new Random();

        static int numOfTestQCounter;

        static List<int> numQGenerated = new List<int>();
        static int testNumber = 0;
        static double numOfQuestions = 0.0;
        
        static void InitializeTest()
        {
            do
            {
                try
                {
                    Console.WriteLine("How many questions do you want?");
                    numOfTestQCounter = 0;
                    int result = int.Parse(Console.ReadLine());
                    if (result > 0 & result <= 13)
                        numOfQuestions = result;
                    else
                        throw new OperationCanceledException("pick a number between 1 to 13\n");
                }
                catch (OperationCanceledException oCe)
                {
                    Console.WriteLine(oCe.Message);
                    numOfTestQCounter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number between 1 to 13");
                    numOfTestQCounter++;
                }
            } while (numOfTestQCounter != 0);

            for (int i = 0; i < Initialize.Questions.Count; i++)
                numQGenerated.Add(i);
        }
        public static void Test()
        {

            InitializeTest();

            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.Clear();
                testNumber = testGenerator.Next(numQGenerated.Count);
                PrintQuestions(numQGenerated[testNumber]);
                GetUserInput();
                CheckInput(numQGenerated[testNumber], answerInputResult);
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                numQGenerated.Remove(numQGenerated[testNumber]);
                userAnswer.Clear();
            }
            CalculateScore();

        }
    }
}
