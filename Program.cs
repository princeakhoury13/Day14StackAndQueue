﻿namespace Day14StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack <int> stack  = new Stack<int>();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);

            foreach(int ele in stack)
            {
                Console.WriteLine(ele);
            }
        }
    }
}