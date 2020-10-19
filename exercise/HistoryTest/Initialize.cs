using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13_william
{
    class Initialize
    {
        static string[] TestBank = File.ReadAllLines(@"D:\quantico06\ISTA421\exercise\ex13-william\TestBank.txt");
        static List<string> ReConstructedStrings = new List<string>();
        public static List<string> Questions = new List<string>();
        public  static List<string> Answers = new List<string>();

        static int keyCounter = 0;
        public static string[,] AnswerKeys = new string[13, 4];

        static void OrganizeStringInFile()
        {
            for (int i = 0; i < TestBank.Length; i++)
            {
                string[] question = TestBank[i].Split('"');
                for (int j = 0; j < question.Length; j++)
                    if (question[j].Length > 2)
                        ReConstructedStrings.Add(question[j]);
            }
        }
        static void SeperateQFromA()
        {
            for (int i = 0; i < ReConstructedStrings.Count; i++)
            {
                if (i % 5 == 0)
                    Questions.Add(ReConstructedStrings[i]);
                else
                    Answers.Add(ReConstructedStrings[i]);
            }
        }
        static void GroupAnswers()
        {
            for (int i = 0; i < Questions.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    AnswerKeys[i, j] = Answers[keyCounter];
                    keyCounter++;
                }
            }
        }
        public static Dictionary<string, string> FinalTestBank = new Dictionary<string, string>();
        static void ConstructTestBank()
        {
            for (int i = 0; i < Questions.Count; i++)
                FinalTestBank.Add(Questions[i], AnswerKeys[i,0]);
        }

        public static void PrepTestBank()
        {
            OrganizeStringInFile();
            SeperateQFromA();
            GroupAnswers();
            ConstructTestBank();
        }

    }
}
