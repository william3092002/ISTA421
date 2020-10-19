using System;


namespace ex_10_william
{
    public class BaseFunc
    {
        public static string DecimalTo(int input, int baseNum)
        {
            string OutPutNumber = "";
            do
            {
                if (baseNum == 2 | baseNum == 8)
                {
                    int remainder = input % baseNum;
                    OutPutNumber += remainder.ToString();
                    input /= baseNum;
                }
                else if (baseNum == 16)
                {
                    int remainder = input % baseNum;
                    if (remainder > 9)
                    {
                        switch (remainder)
                        {
                            case 10:
                                OutPutNumber += 'A';
                                break;
                            case 11:
                                OutPutNumber += 'B';
                                break;
                            case 12:
                                OutPutNumber += 'C';
                                break;
                            case 13:
                                OutPutNumber += 'D';
                                break;
                            case 14:
                                OutPutNumber += 'E';
                                break;
                            case 15:
                                OutPutNumber += 'F';
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        OutPutNumber += remainder.ToString();
                    input /= baseNum;
                }
            } while (input != 0);
            char[] result = OutPutNumber.ToCharArray();
            Array.Reverse(result);
            string finalResult = new string(result);
            return finalResult;
        }

        public static string ToDecimal(string input, int baseNumber)
        {

            int result = 0;
            if (baseNumber == 2)
            {
                int placeCounter = 0;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] == '1')
                        result += (int)Math.Pow(2, placeCounter);
                    placeCounter++;
                }
            }
            else if (baseNumber == 8)
            {
                int placeCounter = 0;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    result += int.Parse(input[i].ToString()) *
                        (int)Math.Pow(8, placeCounter);
                    placeCounter++;
                }
            }
            else if (baseNumber == 16)
            {
                int placeCounter = 0;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (char.IsLetter(input[i]))
                    {
                        char newInput = char.ToUpper(input[i]);
                        switch (newInput)
                        {
                            case 'A':
                                result += 10 * (int)Math.Pow(16, placeCounter);
                                break;
                            case 'B':
                                result += 11 * (int)Math.Pow(16, placeCounter);
                                break;
                            case 'C':
                                result += 12 * (int)Math.Pow(16, placeCounter);
                                break;
                            case 'D':
                                result += 13 * (int)Math.Pow(16, placeCounter);
                                break;
                            case 'E':
                                result += 14 * (int)Math.Pow(16, placeCounter);
                                break;
                            case 'F':
                                result += 15 * (int)Math.Pow(16, placeCounter);
                                break;
                            default:
                                break;
                        }
                        placeCounter++;
                    }
                    else
                    {
                        result += int.Parse(input[i].ToString()) * (int)Math.Pow(16, placeCounter);
                        placeCounter++;
                    }
                }
            }
            return result.ToString();
        }
    }
}
