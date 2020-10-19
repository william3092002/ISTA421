using System;


namespace ex_10_william
{
    public class Util
    {
        public static int Menu()
        {
            int sepLenght = 27;
            Console.Clear();
            PrintSeperator(40, '=');
            Console.WriteLine(
                "\nPlease select a type for your input:\n" +
                "A: Binary\n" +
                "B: Octal\n" +
                "C: Decimal\n" +
                "D: Hexidecimal");
            PrintSeperator(40, '=');
            Console.WriteLine();
            string userChoice = Console.ReadLine().ToUpper();
            Console.Clear();

            switch (userChoice)
            {
                case "A":
                    Console.Write("Enter a Binary Number: ");
                    string inputNum = Console.ReadLine();
                    PrintSeperator(sepLenght, '-');
                    Console.WriteLine($"\nBinary: {inputNum}\n" +
                        $"Octal: {BinToOct(inputNum)}\n" +
                        $"Decimal: {BinToDec(inputNum)}\n" +
                        $"Hexidecimal: {BinToHex(inputNum)}");
                    PrintSeperator(sepLenght, '-');
                    break;

                case "B":
                    Console.Write("Enter a Octal Number: ");
                    inputNum = Console.ReadLine();
                    PrintSeperator(sepLenght, '-');
                    Console.WriteLine($"\nBinary: {OctToBin(inputNum)}\n" +
                        $"Octal: {inputNum}\n" +
                        $"Decimal: {OctToDec(inputNum)}\n" +
                        $"Hexidecimal: {OctToHex(inputNum)}");
                    PrintSeperator(sepLenght, '-');
                    break;

                case "C":
                    Console.Write("Enter a Decimal Number: ");
                    inputNum = Console.ReadLine();
                    PrintSeperator(sepLenght, '-');
                    Console.WriteLine($"\nBinary: {DecToBin(inputNum)}\n" +
                        $"Octal: {DecToOct(inputNum)}\n" +
                        $"Decimal: {inputNum}\n" +
                        $"Hexidecimal: {DecToHex(inputNum)}");
                    PrintSeperator(sepLenght, '-');
                    break;

                case "D":
                    Console.Write("Enter a Hexadecimal Number: ");
                    inputNum = Console.ReadLine();
                    PrintSeperator(sepLenght, '-');
                    Console.WriteLine($"\nBinary: {HexToBin(inputNum)}\n" +
                        $"Octal: {HexToOct(inputNum)}\n" +
                        $"Decimal: {HexToDec(inputNum)}\n" +
                        $"Hexidecimal: {inputNum}");
                    PrintSeperator(sepLenght, '-');
                    break;

                default:
                    break;
            }
            Console.WriteLine("\nContinue or Exit?\n" +
                "1: Continue\n" +
                "2: Exit\n");
            string InputConEx = Console.ReadLine();
            if (InputConEx == "1")
                return 1;
            else
                return 0;
        }

        public static string BinToOct(string input) =>
            BaseFunc.DecimalTo(int.Parse(BaseFunc.ToDecimal(input, 2)), 8);
        public static string BinToDec(string input) =>
            BaseFunc.ToDecimal(input, 2);
        public static string BinToHex(string input) =>
            BaseFunc.DecimalTo(int.Parse(BaseFunc.ToDecimal(input, 2)), 16);
        public static string OctToBin(string input) =>
            BaseFunc.DecimalTo(int.Parse(BaseFunc.ToDecimal(input, 8)), 2);
        public static string OctToDec(string input) =>
            BaseFunc.ToDecimal(input, 8);
        public static string OctToHex(string input) =>
            BaseFunc.DecimalTo(int.Parse(BaseFunc.ToDecimal(input, 8)), 16);
        public static string DecToBin(string input) =>
            BaseFunc.DecimalTo(int.Parse(input), 2);
        public static string DecToOct(string input) =>
            BaseFunc.DecimalTo(int.Parse(input), 8);
        public static string DecToHex(string input) =>
            BaseFunc.DecimalTo(int.Parse(input), 16);
        public static string HexToBin(string input) =>
            BaseFunc.DecimalTo(int.Parse(BaseFunc.ToDecimal(input, 16)), 2);
        public static string HexToOct(string input) =>
            BaseFunc.DecimalTo(int.Parse(BaseFunc.ToDecimal(input, 16)), 8);
        public static string HexToDec(string input) =>
            BaseFunc.ToDecimal(input, 16);
        public static void PrintSeperator(int stringLength, char type)
        {
            for (int i = 0; i < stringLength; i++)
                Console.Write(type);
        }



    }
}
