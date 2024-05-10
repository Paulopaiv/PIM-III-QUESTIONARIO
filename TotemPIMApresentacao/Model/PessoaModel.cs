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
        public void Login(PessoaController pessoa)
        {
            var pessoaEncontrada = pessoaServico.BuscarPorCodigo(pessoa);

            if (pessoaEncontrada == null)
            {
                this.mensagem = "O token fornecido é inválido. Por favor, verifique e tente novamente.";
            }
        }
        public string Mensagem
        {
            get { return mensagem; }
        }

        public PessoaServico PessoaServico
        {
            get => default;
            set
            {
            }
        }

        public PessoaController PessoaController
        {
            get => default;
            set
            {
            }
        }
    }
}
