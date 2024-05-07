using System.Xml.Linq;
using TotemPIMApresentacao.Controller;
using TotemPIMApresentacao.Service;

namespace TotemPIMApresentacao.Model
{
    public class ContadorRespostas
    {
        private int[] posicoesRespostasCorretas;
        private int respostasCorretas;
        private AvaliacaoService avaliacaoService = new AvaliacaoService();
        private PessoaController pessoa;

        public ContadorRespostas(PessoaController pessoa)
        {
            this.pessoa = pessoa;
        }

        public ContadorRespostas(int[] posicoesRespostasCorretas)
        {
            this.posicoesRespostasCorretas = posicoesRespostasCorretas;
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

        internal void SalvarResposta()
        {
            if (pessoa != null)
            {
                string codigoUsuario = pessoa.Codigo;
                avaliacaoService.RegistrarPontos(respostasCorretas, codigoUsuario);
            }
            else
            {
             MessageBox.Show("O objeto pessoa é nulo.");
            }
        }
    }

}