using TotemPIMApresentacao.Controller;
using TotemPIMApresentacao.Model;


namespace TotemPIMApresentacao.View
{
    public partial class LoginApollo_11 : Form
    {
        private PessoaModel pessoaModel;
        private PessoaController pessoa;
        private Teclado teclado;
        public string LoginStatus { get; private set; }

        public LoginApollo_11()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pessoa = new PessoaController();
            pessoaModel = new PessoaModel();
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
        private void Atalho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                this.Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            pessoa.Codigo = txbCodigoVisitante.Text;
            pessoaModel.Login(pessoa);

            if (pessoaModel.Mensagem.Equals(""))
            {              
                string codigoUsuario = pessoa.Codigo;
                ContadorRespostas contadorRespostas = new ContadorRespostas(codigoUsuario);

                QuestionarioApollo11 questionarioApollo11 = new QuestionarioApollo11(contadorRespostas, codigoUsuario);
                questionarioApollo11.ShowDialog();
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

        private void Atalho_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Atalho_KeyDown;
        }
    }
}
