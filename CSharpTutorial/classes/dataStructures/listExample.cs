using System.Collections;

namespace LearningCSharp.DataStructures
{
    public static class ListExample
    {
        public static void Run()
        {
            //Listas permitem tamanhos dinâmicos com a definição de tipos 
            var Lista = new List<string>(2)
            {
                "Altman",
                "Musk"
            };

            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }

            Lista.Add("Pikanha");
            Lista.Add("Peixe");

        }
    }
}