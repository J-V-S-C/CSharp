namespace LINQ
{
    public static class WorkingWithLINQ
    {
        // Filtra os caracteres de uma string com base em uma condição
        public static void WhereMethodString()
        {
            string completeName = "Tywin Lannister";

            Func<char, bool> filter = c => c == 'n';
            var result = from c in completeName where c == 'n' select c;

            foreach (var letter in result)
            {
                Console.WriteLine(letter);
            }
        }

        // Filtra os números do array que atendem a uma condição
        public static void WhereMethodNumber()
        {
            var numbers = new int[] { 1, 23, 10, 47, 5 };
            var result = numbers.Where(p => p > 10);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        // Ordena os números e nomes em ordem crescente e decrescente
        public static void Ordering()
        {
            var numbers = new int[] { 1, 43, 0, 56, -2 };
            var names = new string[] { "Marco", "Spencer", "Roy", "Cristina" };

            var orderedNames = names.OrderBy(p => p);
            var result = numbers.OrderBy(p => p);
            var result2 = numbers.OrderByDescending(p => p);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            foreach (var number in result2)
            {
                Console.WriteLine(number);
            }
            foreach (var name in orderedNames)
            {
                Console.WriteLine(name);
            }
        }

        // Seleciona uma quantidade limitada de elementos do array que atendem a uma condição
        public static void Take()
        {
            var numbers = new int[] { 1, 43, 0, 56, -2, 52452, 76, 0 };
            var result = numbers.Where(p => p > 10).Take(3).OrderBy(p => p);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        // Conta os elementos de um array que atendem a uma condição
        public static void Count()
        {
            var numbers = new int[] { 1, 43, 0, 56, -2, 52452, 76, 0 };
            var result = numbers.Count(p => p > 2000);

            Console.WriteLine(result);
        }

        // Retorna o primeiro elemento que atende a condição ou um valor padrão
        public static void FirstANDFirstOrDefault()
        {
            var numbers = new int[] { 1, 43, 0, 56, -2, 52452, 76, 0 };
            var result = numbers.FirstOrDefault(p => p > 1000000, 69);

            Console.WriteLine(result);
        }

        // Retorna o último elemento que atende a condição ou um valor padrão
        public static void LastANDLastOrDefault()
        {
            var numbers = new int[] { 1, 43, 0, 56, -2, 52452, 76, 0 };
            var result = numbers.LastOrDefault(p => p > 1000000, 69);

            Console.WriteLine(result);
        }

        // Mapeia os itens do array e os transforma de acordo com o parâmetro
        public static void Select()
        {
            var numbers = new int[] { 1, 43, 0, 56, -2, 52452, 76, 320 };
            var result = numbers.Select(n => n * 2);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        // Faz tudo que o Select faz e combina diferentes coleções em uma só sequência
        public static void SelectMany()
        {
            var numbers = new int[] { 1, 43, 56 };
            var names = new string[] { "Marco", "Spencer", "Roy", "Cristina" };

            var result = numbers.SelectMany(n => names, (n, name) => new { Number = n, Name = name });

            foreach (var item in result)
            {
                Console.WriteLine($"Number: {item.Number}, Name: {item.Name}");
            }
        }

        // Ignora os primeiros elementos do array ou os últimos (com SkipLast)
        public static void Skip()
        {
            var numbers = new int[] { 1, 43, 56, 69, 432, 65, 34223 };

            var result = numbers.Skip(3);
            result = result.SkipLast(3);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        // Ignora os elementos até que uma condição pare de ser verdadeira
        public static void SkipWhile()
        {
            var numbers = new int[] { 1, 43, 56, 432, 65, 34223 };
            var result = numbers.OrderBy(p => p).SkipWhile(p => p < 100);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        // Remove itens duplicados
        public static void Distinct()
        {
            var numbers = new int[] { 1, 43, 1, 43, 65, 34223 };
            var result = numbers.Distinct();

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        // Faz a união de dois arrays eliminando os itens repetidos
        public static void Union()
        {
            var numbers = new int[] { 1, 43, 1, 43, 65, 34223 };
            var numbers2 = new int[] { 1, 403, 1, 4323, 65, 423 };

            var result = numbers.Union(numbers2);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        // Pega somente a interseção de dois arrays
        public static void Intersect()
        {
            var numbers = new int[] { 1, 43, 1, 43, 65, 34223 };
            var numbers2 = new int[] { 1, 403, 1, 4323, 65, 423 };

            var result = numbers.Intersect(numbers2);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        // Fica com os elementos que não estão no segundo array
        public static void Except()
        {
            var numbers = new int[] { 1, 43, 1, 43, 65, 34223 };
            var numbers2 = new int[] { 1, 403, 1, 4323, 65, 423 };

            var result = numbers.Except(numbers2);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }

        // Permite uma agregação personalizada em uma sequência
        public static void Aggregate()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = numbers.Aggregate((total, next) => total + next);

            Console.WriteLine(result);

            var words = new[] { "C#", "é", "muito", "legal" };
            var sentence = words.Aggregate((current, next) => current + ' ' + next);

            Console.WriteLine(sentence);
        }

        // Agrupa os elementos do array em grupos com base em uma lógica
        public static void GroupBy()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var grouped = numbers.GroupBy(n => n % 2 == 0 ? "Par" : "Ímpar");

            foreach (var group in grouped)
            {
                Console.WriteLine($"Group: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Verifica se todos os elementos satisfazem uma condição
        public static void All()
        {
            var numbers = new int[] { 1, 2, -3, 4, 5, 6 };
            var areAllPositive = numbers.All(n => n > 0);

            Console.WriteLine(areAllPositive);
        }

        // Verifica se pelo menos um item do array satisfaz a condição
        public static void Any()
        {
            var numbers = new int[] { 1, 2, -3, 4, 5, 6 };
            var anyIsPositive = numbers.Any(n => n < 0);

            Console.WriteLine(anyIsPositive);
        }

        // Pega o menor, maior, soma e média dos itens do array
        public static void Operations()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };

            var min = numbers.Min();
            var max = numbers.Max();
            var sum = numbers.Sum();
            var average = numbers.Average();

            Console.WriteLine($"Min: {min}, Max: {max}, Sum: {sum}, Average: {average}");
        }

        // Permite declarar um valor padrão caso o array esteja vazio
        public static void DefaultEmpty()
        {
            var numbers = new int[] { };

            var result = numbers.DefaultIfEmpty(-1);

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }

        // Compara duas coleções para ver se são exatamente iguais
        public static void SequenceEqual()
        {
            var numbers1 = new[] { 1, 2, 3 };
            var numbers2 = new[] { 1, 2, 3 };
            var numbers3 = new[] { 3, 2, 1 };

            var areEqual1 = numbers1.SequenceEqual(numbers2);
            var areEqual2 = numbers1.SequenceEqual(numbers3);

            Console.WriteLine(areEqual1);
            Console.WriteLine(areEqual2);
        }
    }
}
