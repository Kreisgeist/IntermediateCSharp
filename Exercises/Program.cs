using System.Collections;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXCERCISE 1
            //activateStopwatch();

            //EXCERCISE 2
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        public static void activateStopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            ConsoleKey decision;
            bool isPainted = false;
            bool isStarted = false;

            do
            {
                if (!isPainted)
                {
                    Console.Clear();
                    Console.WriteLine("Start stopwatch (Enter) - Stop watch (ESC) - Exit (Space)");
                    isPainted = true;
                }

                decision = Console.ReadKey().Key;

                if (!isStarted && decision == ConsoleKey.Enter)
                {
                    isStarted = true;
                    Console.WriteLine(stopwatch.Start() + "Press stop when ready");
                }
                else if (isStarted && decision == ConsoleKey.Escape)
                {
                    Console.WriteLine("Time elapsed: {0}; Press 1 to continue", stopwatch.Stop());
                    isPainted = false;
                    isStarted = false;
                    do
                    {
                        decision = Console.ReadKey().Key;
                    } while (decision != ConsoleKey.D1);
                } 

            } while (decision != ConsoleKey.Spacebar);

        }

    }
}