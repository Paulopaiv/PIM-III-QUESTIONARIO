using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;

namespace TotemPIMApresentacao.Model
{
    public class ContadorRespostas
    {
        private int[] posicoesRespostasCorretas;
        private int respostasCorretas;

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
    }
}