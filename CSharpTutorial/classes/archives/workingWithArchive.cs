namespace archives
{
    public class WorkingWithArchives
    {
        private const string filename = "Testing.txt";
        public static void creatingArchive()
        {
            var write = new StreamWriter(filename, true);
            Console.Write("Informe um nome:");
            var name = Console.ReadLine();
            write.WriteLine($"ID...: {Random.Shared.Next(1, 100)}");
            write.WriteLine($"Nome {name}");
            write.WriteLine("----------------");
            write.Close();
        }

        public static void readingAllArchive()
        {
            var content = File.ReadAllText(filename);
            Console.WriteLine(content);
        }

        public static void readingArchive()
        {
            var read = new StreamReader(filename);
            string forbiddenWord;
            do
            {
                Console.Write("Write the forbidden word... ---> ");
                forbiddenWord = Console.ReadLine();
                if (forbiddenWord.Length < 2)
                {
                    Console.WriteLine("It's a word, not a char, it must have at minimaum 2 caracteres");
                }
            } while (forbiddenWord.Length < 2);


            while (!read.EndOfStream)
            {

                var block = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    block[i] = read.ReadLine();
                }

                if (!block.Any(line => line.Contains(forbiddenWord)))
                {
                    foreach (var line in block)
                    {
                        Console.WriteLine(line);

                    }
                }

            }
            read.Close();
        }


        public static void deletingArchives()
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
        }
    }
}