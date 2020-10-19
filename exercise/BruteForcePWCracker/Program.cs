using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex_15_william
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your password: ");
            string InputPassCode = Console.ReadLine();
            char[] ArrayPassCode = InputPassCode.ToCharArray();
            int NumOfPassCode = InputPassCode.Length;

            char[][] input;
            input = new char[NumOfPassCode][];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = new char[127 - 33];
                int CharPassCode = 33;
                for (int j = 0; j < 127 - 33; j++)
                {
                    input[i][j] = (char)CharPassCode;
                    CharPassCode++;
                }
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();

            IEnumerable<char[]> result = CartesianProduct(input);

            watch.Stop();
            //string test = "%4@";

            object Locker = new object();

            Stopwatch watch1 = new Stopwatch();

            watch1.Start();

            //List<char[]> AllPossible = new List<char[]>();

            CancellationTokenSource cts = new CancellationTokenSource();

            ParallelOptions Po = new ParallelOptions();
            Po.CancellationToken = cts.Token;
            Po.MaxDegreeOfParallelism = Environment.ProcessorCount;

            Task.Factory.StartNew(() =>
            {
                if (char.IsLetterOrDigit(Console.ReadKey().KeyChar))
                    cts.Cancel();
            });

            try
            {
                Parallel.ForEach(result, Po, (item, state) =>
                {
                    //lock (Locker)
                    //{
                    bool validate = true;
                    for (int i = 0; i < InputPassCode.Length; i++)
                    {
                        if (item[i] != InputPassCode[i])
                        {
                            validate = false;
                            break;
                        }
                    }
                    Console.Write(item);
                    if (validate == true)
                    {
                        Console.WriteLine(item);
                        state.Break();
                    }
                    Po.CancellationToken.ThrowIfCancellationRequested();
                    //}
                    //lock (AllPossible)
                    //{
                    //    AllPossible.Add(item);
                    //}
                });
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine($"\n{e.Message}");
            }
            finally
            {
                cts.Dispose();
            }

            //foreach (var item in result)
            //{
            //    bool validate = true;
            //    for (int i = 0; i < InputPassCode.Length; i++)
            //    {
            //        if (item[i] != InputPassCode[i])
            //        {
            //            validate = false;
            //            break;
            //        }
            //    }
            //    if (validate == true)
            //    {
            //        Console.WriteLine(item);
            //        break;
            //    }
            //}
            watch1.Stop();


            Console.WriteLine($"\n{watch.Elapsed}");
            Console.WriteLine(watch1.Elapsed);
            //Console.WriteLine($"Items in list = {PassCodeBank.Count}");
            //Console.WriteLine(result.Count());
        }

        public static IEnumerable<char[]> CartesianProduct(params char[][] inputs)
        {
            return inputs.Aggregate(
                (IEnumerable<char[]>)new char[][] { new char[0] },
                (soFar, input) =>
                from prevProductItem in soFar
                from item in input
                select prevProductItem.Concat(new char[] { item }).ToArray());
        }

        //public static IEnumerable<char[]> CartesianProduct(params char[][] inputs)
        //{
        //    IEnumerable<char[]> soFar = new char[][] { new char[0] };
        //    foreach (var input in inputs)
        //    {
        //        var currentInput = input;
        //        soFar = soFar.SelectMany(prevProductItem =>
        //        from item in currentInput
        //        select prevProductItem.Concat(new char[] { item }).ToArray());
        //    }
        //    return soFar;
        //}




    }
}
