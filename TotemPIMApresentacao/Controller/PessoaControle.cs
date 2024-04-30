using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;

namespace TotemPIMApresentacao.Controller
{
    public class PessoaControle
    {
        private string nome;
        private string codigo;

        public PessoaControle()
        {

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
