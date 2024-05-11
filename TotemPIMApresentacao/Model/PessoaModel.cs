using TotemPIMApresentacao.Servico;
using TotemPIMApresentacao.Controller;
using TotemPIMApresentacao.Service;

namespace TotemPIMApresentacao.Model
{
    public class PessoaModel
    {
        PessoaServico pessoaServico = new PessoaServico(new Dbconexao());
        QuestionarioService questionario = new QuestionarioService();

        private string mensagem = "";
      
        public PessoaModel()
        {

        }
        public bool Login(PessoaController pessoa,string obraAtual)
        {
            var pessoaEncontrada = pessoaServico.BuscarPorCodigo(pessoa);

            if (pessoaEncontrada != null)
            {
                // Verificar se o código está associado à obra atual
                bool codigoAssociadoObra = questionario.CodigoAssociadoObra(pessoa.Codigo, obraAtual);

                if (codigoAssociadoObra)
                {
                    this.mensagem = "O token fornecido já está associado à obra atual.";
                    return false;
                }
            }

            return true;
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
