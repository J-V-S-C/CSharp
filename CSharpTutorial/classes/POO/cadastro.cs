namespace LearningCSharp.POO
{
    public static class Cadastro
    {
        public static class Heranca
        {
            public static void Run()
            {
                PessoaFisica pessoa = new PessoaFisica();
                pessoa.Nome = "João";
                pessoa.Idade = 25;
                pessoa.Email = "joao@example.com";
                pessoa.CPF = "123.456.789-00";
                pessoa.ImprimirDadosPessoaFisica();
            }
        }
        public class Produto
        {
            public string Nome { get; set; }
            //get significa que vai ter acesso aos valores da instancia, set é para falar que pode atribuir valores
            public double Preco { get; set; }


            public static void WriteDescription()
            {
                Produto Refrigerante = new Produto();
                Refrigerante.Nome = "Coca-Cola";
                Refrigerante.Preco = 5.99;
                Console.WriteLine($"Produto: {Refrigerante.Nome} - Preço: {Refrigerante.Preco}");
            }
        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Email { get; set; }



            public void ImprimirDadosPessoa()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Idade: {Idade}");
                Console.WriteLine($"Email: {Email}");
            }

        }

        public class PessoaFisica : Pessoa
        {
            public string CPF { get; set; }
            public void ImprimirDadosPessoaFisica()
            {
                base.ImprimirDadosPessoa();
                Console.WriteLine($"CPF: {CPF}");
            }
        }

        public record Curso(int Id, string Descricao);

        public class CursoTeste
        {
            public int Id { get; set; }
            public string Descricao { get; set; }
            /*
                public override bool Equals(object? obj)
                {
                    if (obj is null)
                    {
                        return false;
                    }
                    if (obj is Curso curso)
                    {
                        return Id == curso.Id && Descricao == curso.Descricao;
                    }
                    return base.Equals(obj);
                }

                public static bool operator ==(Curso a, Curso b)
                {
                    return a.Equals(b);
                }
                public static bool operator !=(Curso a, Curso b)
                {
                    return a.Equals(b);
                }
            */
        }



    }
}