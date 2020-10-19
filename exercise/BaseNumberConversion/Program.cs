using System;


namespace ex_10_william
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my mini Programmer Calculator");
            int GameState;
            do
            {
                GameState = Util.Menu();
            } while (GameState != 0);
            //Console.WriteLine(BaseFunc.ToDecimal("101110", 2)); 
        }
       
       
    }
}
