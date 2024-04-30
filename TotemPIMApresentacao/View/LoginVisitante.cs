using TotemPIMApresentacao.Controller;
using TotemPIMApresentacao.Model;


namespace TotemPIMApresentacao.View
{
    public partial class LoginVisitante : Form
    {
        private PessoaModel pessoaModel;
        private PessoaControle pessoa;
        private Teclado teclado;
        public string LoginStatus { get; private set; }

        public LoginVisitante()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            pessoa = new PessoaControle();
            pessoaModel = new PessoaModel();
            LoginStatus = "Erro";

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            // Verifica se o teclado ainda não foi instanciado
            if (teclado == null)
            {
                // Cria uma nova instância do teclado
                teclado = new Teclado();
            }

            // Define a TextBox clicada como o TextBox de destino do teclado
            teclado.SetTargetTextBox(sender as TextBox);

            teclado.Show();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            pessoa.Codigo = txbCodigoVisitante.Text;

            pessoaModel.Login(pessoa);

            if (pessoaModel.Mensagem.Equals($"Olá, {pessoa.Nome}! Por favor, responda o questionário a seguir."))
            {
                MessageBox.Show(pessoaModel.Mensagem);
                LoginStatus = "Logado";
                this.Close();
            }
            else
            {
                MessageBox.Show(pessoaModel.Mensagem);
            }
            LimparCampos();
        }
        private void LimparCampos()
        {
            txbCodigoVisitante.Text = string.Empty;
        }
    }
}
