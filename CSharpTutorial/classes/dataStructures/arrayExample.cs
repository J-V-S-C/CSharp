using System.Collections;

namespace LearningCSharp.DataStructures
{
    public static class ArrayExample
    {
        public static void Run()
        {

            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Ola");
            arrayList.Add(false);
            arrayList.Add(43.642);
            arrayList.RemoveAt(2);

            foreach (var item in arrayList)
            {
                Console.WriteLine($"Método foreach --> {item}");
            }



            for (int i = 0; i < arrayList.Capacity; i++)
            {
                Console.WriteLine($"Método For --> {arrayList[i]}");
            }
            //Pode gerar mais erros

            var MyArray = new int[9] { 2, 4, 6, 2, 43, 32, 43, 43, 54 };

            Array.Resize(ref MyArray, 10);

            MyArray[9] = 31;


            foreach (var item in MyArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}