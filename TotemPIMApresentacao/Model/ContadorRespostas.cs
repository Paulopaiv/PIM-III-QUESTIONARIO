using System.Windows.Forms;
using System.Xml.Linq;
using TotemPIMApresentacao.Controller;
using TotemPIMApresentacao.Service;

namespace TotemPIMApresentacao.Model
{
    public class ContadorRespostas
    {
        private QuestionarioService avaliacaoService = new QuestionarioService();
        private int[] posicoesRespostasCorretas;
        private int respostasCorretas;
        private string codigoUsuario;
        private string obraAtual;
        private string mensagem;
        public ContadorRespostas(string codigoUsuario)
        {
            this.codigoUsuario = codigoUsuario;
        }
        public ContadorRespostas(int[] posicoesRespostasCorretas, string codigoUsuario, string obraAtual)
        {
            this.posicoesRespostasCorretas = posicoesRespostasCorretas;
            this.codigoUsuario = codigoUsuario;
            this.obraAtual = obraAtual; // Aqui atribuímos o valor de obraAtual à propriedade obraAtual
            respostasCorretas = 0;
        }


        public void VerificarResposta(int indicePergunta, int respostaUsuario)
        {
            if (indicePergunta < posicoesRespostasCorretas.Length && respostaUsuario == posicoesRespostasCorretas[indicePergunta])
            {
                Incrementar();
            }
        }

        public int RespostasCorretas
        {
            get { return respostasCorretas; }
        }

        public void Incrementar()
        {
            respostasCorretas++;
        }

        public string ObraAtual { get; set; }

        internal void SalvarResposta()
        {
            avaliacaoService.RegistrarPontos(respostasCorretas, codigoUsuario, ObraAtual);

        }
        public void Quantidade()
        {
            int quant = respostasCorretas;

            // Exibir as informações em uma caixa de mensagem

            Mensagem = ($"{quant}");
        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
    }

}