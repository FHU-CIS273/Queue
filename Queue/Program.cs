using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>();

            queue.Add("A");
            queue.Add("B");
            queue.Add("C");
            queue.Add("D");

            Console.WriteLine(queue.Front);
            Console.WriteLine(queue.Back);
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
            Console.WriteLine(queue.Remove());
        }
    }
}
