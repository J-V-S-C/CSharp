namespace LearningCSharp.ControlStructures
{
    public static class Functions
    {
        public static void Run()
        {

            Func<String> Value = () => "Donald Trump";
            Console.WriteLine(Value());


            int SomandoValores(int x, int y)
            {
                return x + y;
            }
            int Result = SomandoValores(2, 4);
            int Result2 = SomandoValores(9, 1);
            double Result3 = Div(Result, Result2);
            Console.WriteLine(Result3);


        }

        public static double Div(double a, double b)
        {
            return a / b;
        }
    }
}