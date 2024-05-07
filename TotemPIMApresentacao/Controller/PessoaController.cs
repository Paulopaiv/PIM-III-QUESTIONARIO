using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;

namespace TotemPIMApresentacao.Controller
{
    public class PessoaController
    {
        private string nome;
        private string codigo;


        public PessoaController()
        {

        }

        public PessoaController(string nome, string codigo)
        {
            this.nome = nome;
            this.codigo = codigo;

        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
    }
}
