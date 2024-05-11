using TotemPIMApresentacao.Controller;
using TotemPIMApresentacao.Model;
using WinFormsTimer = System.Windows.Forms.Timer;


namespace TotemPIMApresentacao.View
{
    public partial class LoginReplica : Form
    {
        private PessoaModel pessoaModel;
        private PessoaController pessoa;
        private Teclado teclado;
        private WinFormsTimer timer;

     
        public LoginReplica()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pessoa = new PessoaController();
            pessoaModel = new PessoaModel();


            timer = new WinFormsTimer();
            timer.Interval = 30000;
            timer.Tick += Timer_Tick;

            timer.Start();
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
            pessoaModel.Login(pessoa, "Replica");

            if (pessoaModel.Mensagem.Equals(""))
            {
                string codigoUsuario = pessoa.Codigo;
                ContadorRespostas contadorRespostas = new ContadorRespostas(codigoUsuario);

                QuestionarioReplica questionarioReplica = new QuestionarioReplica(contadorRespostas, codigoUsuario);
                questionarioReplica.ShowDialog();
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
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
            timer.Stop();
        }
    }
}
