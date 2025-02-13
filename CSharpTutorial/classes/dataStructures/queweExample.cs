

using System;

namespace LearningCSharp.DataStructures
{
    public static class QueueExample
    {
        public static void Run()
        {
            var quewe = new Queue<string>();
            quewe.Enqueue("Manoel");
            quewe.Enqueue("Gomes");

            var name = quewe.Peek();
            //var Lastname = quewe.Peek();

            //var name = quewe.Dequeue();
            var Lastname = quewe.Dequeue();

            Console.WriteLine(name);
            Console.WriteLine(Lastname);




            foreach (var item in quewe)
            {
                Console.WriteLine(item);
            }

        }
    }
}