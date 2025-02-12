using System;

namespace LearningCSharp.DataStructures
{
    public static class StackExample
    {
        public static void Run()
        {
            var stack = new Stack<string>();
            stack.Push("Serjão");
            stack.Push("Foguetes");

            var Name = stack.Pop();
            Console.WriteLine(Name);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}