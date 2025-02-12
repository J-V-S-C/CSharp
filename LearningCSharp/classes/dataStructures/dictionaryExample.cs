using System.Collections;

namespace LearningCSharp.DataStructures
{
    public static class DictionaryExample
    {
        public static void Run()
        {

            var dic = new Dictionary<int, string>(){
            {3, "Hello"},
            {8000, "Mais de 8000"},
        };
            var name = dic[8000];
            foreach (var item in dic)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}