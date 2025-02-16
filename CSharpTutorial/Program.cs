using System.Collections;
using LearningCSharp.DataStructures;
using LearningCSharp.ControlStructures;
using LearningCSharp.POO;
using System.IO.Pipelines;
using LearningCSharp.Date;
using LearningCSharp.Exceptions;
using archives;
using LINQ;

//StackExample.Run();
//QueueExample.Run();
//DictionaryExample.Run();
//ListExample.Run();
//ArrayExample.Run();
//Functions.Run();
//While.Run();
//DoWhile.Run();
//TryParse.Run();
//Produto.WriteDescription();
//Cadastro.Heranca.Run();
//CursoCSharp.AulaRecord();
//CursoCSharp.Arrays.Contains();
//CursoCSharp.Arrays.Trim();
//CursoCSharp.Arrays.StartWithEndWith();
//CursoCSharp.Arrays.Replace();
//DateMethods.WorkingWithDates();
//DateMethods.SubtractingDates();
//DateMethods.AddDates();
//DateMethods.weekDay();
//DateMethods.dateOnly();
//LearningCSharp.Exceptions.ExceptionClass.Run();
//TreatingExceptions.Run();
//WorkingWithArchives.creatingArchive();
//WorkingWithArchives.readingAllArchive();
//WorkingWithArchives.readingArchive();
//WorkingWithArchives.deletingArchives();
//WorkingWithLINQ.WhereMethodString();
//WorkingWithLINQ.WhereMethodNumber();
//WorkingWithLINQ.Ordering();
//WorkingWithLINQ.Take();
//WorkingWithLINQ.Count();
//WorkingWithLINQ.FirstANDFirstOrDefault();
//WorkingWithLINQ.LastANDLastOrDefault();
//WorkingWithLINQ.Select();
//WorkingWithLINQ.SelectMany();
//WorkingWithLINQ.Skip();
//WorkingWithLINQ.SkipWhile();
//WorkingWithLINQ.Distinct();
//WorkingWithLINQ.Union();
//WorkingWithLINQ.Intersect();
//WorkingWithLINQ.Except();
//WorkingWithLINQ.Aggregate();
//WorkingWithLINQ.GroupBy();
//WorkingWithLINQ.All();
//WorkingWithLINQ.Any();
//WorkingWithLINQ.Operations();
//WorkingWithLINQ.DefaultEmpty();
WorkingWithLINQ.SequenceEqual();
class CursoCSharp
{
    //Record é tipo uma classe, mas ele é imutável após a instancia, permite comparar objetos public static void AulaRecord()
    public static void AulaRecord()

    {
        /*
        var curso1 = new Cadastro.Curso()
        {
            Id = 1,
            Descricao = "C#",
        };
        var curso2 = new Cadastro.Curso()
        {
            Id = 1,
            Descricao = "C#",
        };
        */
        /*
            var curso1 = new Cadastro.Curso(1, "C#");
            var curso2 = new Cadastro.Curso(1, "C#");
        */

        //As duas instancias aqui apontam para o mesmo endereço na memória
        /*
        var curso1 = new Cadastro.CursoTeste
        {
            Id = 1,
            Descricao = "C#",
        };
        var curso2 = curso1;
        */
        /*
     var curso2 = new Cadastro.CursoTeste
     {
         Id = curso1.Id,
     };
     */
        var curso1 = new Cadastro.Curso(1, "C#");

        var curso2 = curso1 with { Descricao = "C# Avançado" };
        Console.WriteLine(curso1.Descricao);
        Console.WriteLine(curso2.Descricao);
    }

    public static void AulaInterface()
    {
        var notificacao = new Notificacao.NotificacaoEmail();
        notificacao.EnviarMensagem();

        Notificacao.INotificacao notificacao1 = new Notificacao.NotificacaoEmail();
        notificacao1.Descricao = "Teste";
        notificacao1.EnviarMensagem();

    }

    public class Arrays()
    {
        public static void Contains()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            bool Result = array1.Contains(2);
            Console.WriteLine(Result);
        }
        public static void Trim()
        {
            string texto = "**TEXTO**";
            Console.WriteLine($"Meu texto: {texto.Trim('*')}");
            Console.WriteLine($"Inicio: {texto.TrimStart('*')}");
            Console.WriteLine($"Fim: {texto.TrimEnd('*')}");

        }

        public static void StartWithEndWith()
        {
            string texto = "Curso CSharp";
            Console.WriteLine(texto.StartsWith("Curso"));
            Console.WriteLine(texto.EndsWith("CSharp2"));

        }

        public static void Replace()
        {
            string texto = "Curso CSharp";
            Console.WriteLine(texto.Replace("CSharp", "Java"));

        }
    }



}
