namespace LearningCSharp.ControlStructures
{
    public static class While
    {
        public static void Run()
        {
            int i = 0;
            bool boolean = true;
            while (boolean == true)
            {
                i++;
                boolean = false;

            }

            Console.WriteLine(i);

        }
    }
}
