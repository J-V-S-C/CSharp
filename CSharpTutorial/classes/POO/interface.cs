namespace LearningCSharp.POO
{

    public class Notificacao
    {
        public interface INotificacao
        {
            string Descricao { get; set; }
            void EnviarMensagem();
        }

        public class NotificacaoEmail : INotificacao
        {
            public string Descricao { get; set; }
            public void EnviarMensagem()
            {
                Console.WriteLine($"Enviando email: {Descricao}");
            }
        }

        public class NotificacaoFuncionario : INotificacao
        {
            public string Descricao { get; set; }
            public void EnviarMensagem()
            {
                Console.WriteLine($"Enviando mensagem para o funcionário: {Descricao}");
            }
        }
    }

}