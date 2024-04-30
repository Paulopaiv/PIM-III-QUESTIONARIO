using TotemPIMApresentacao.Servico;
using TotemPIMApresentacao.Controller;

namespace TotemPIMApresentacao.Model
{
    public class PessoaModel
    {
        PessoaServico pessoaServico = new PessoaServico(new Dbconexao());

        private string mensagem = "";

        public PessoaModel()
        {

        }

        public void Login(PessoaControle pessoa)
        {
            var pessoaEncontrada = pessoaServico.BuscarPorCodigo(pessoa);

            if (pessoaEncontrada != null)
            {
                this.mensagem = $"Olá, {pessoaEncontrada.Nome}! Por favor, responda o questionário a seguir.";
            }
            else
            {
                this.mensagem = "O token fornecido é inválido. Por favor, verifique e tente novamente.";
            }
        }

        public string Mensagem
        {
            get { return mensagem; }
        }


    }
}
