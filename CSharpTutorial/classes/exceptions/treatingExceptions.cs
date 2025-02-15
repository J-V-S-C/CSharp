namespace LearningCSharp.Exceptions
{
    public static class TreatingExceptions
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Write smth bitch");
                    var number = Console.ReadLine();
                    var Result = 100 / int.Parse(number);
                    Console.WriteLine($"Resultado: {Result}");
                }
                catch (DivideByZeroException Exception)
                {
                    Console.WriteLine($"Division error: {Exception.Message}");
                    Console.WriteLine($"Stack Trace: {Exception.StackTrace}");
                }
                catch (FormatException Exception)
                {
                    Console.WriteLine($"Format error *try putting your dick on it*: {Exception.Message}");
                    Console.WriteLine($"Stack Trace: {Exception.StackTrace}");
                }
                catch (Exception Exception)
                {
                    Console.WriteLine($"Erro: {Exception.Message}");
                    Console.WriteLine($"Stack Trace: {Exception.StackTrace}");
                }

            }
        }
    }

}