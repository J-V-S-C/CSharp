namespace LearningCSharp.ControlStructures
{
    public static class TryParse
    {
        public static void Run()
        {
            string input = "100";
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"Número convertido com sucesso --> {result}!");
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}