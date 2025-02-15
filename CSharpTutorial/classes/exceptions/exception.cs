namespace LearningCSharp.Exceptions
{
    public static class ExceptionClass
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("Escreva um número");
                var number = Console.ReadLine();
                var Result = 100 / int.Parse(number);
                Console.WriteLine($"Resultado: {Result}");
            }
        }
    }

}