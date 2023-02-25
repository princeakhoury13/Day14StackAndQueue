using System.Collections;

namespace Day14StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue <int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            foreach(int ele in queue)
            {
                Console.WriteLine(ele);
            }


            queue.Dequeue();
            Console.WriteLine("After Deque: ");
            foreach (int ele in queue)
            {
                Console.WriteLine(ele);
            }

        }

        
    }
}