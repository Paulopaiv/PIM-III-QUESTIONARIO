using TotemPIMApresentacao.Controller;
using TotemPIMApresentacao.Model;

namespace TotemPIMApresentacao.View
{
    public partial class ResultadoForm : Form
    {
        private ContadorRespostas contadorRespostas;
        private System.Windows.Forms.Label lblRespostaQuestao1;
        public ResultadoForm(ContadorRespostas contadorRespostas)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.contadorRespostas = contadorRespostas;           
            ExibirResultados();
        }
        private void ExibirResultados()
        {
            contadorRespostas.SalvarResposta();
            contadorRespostas.Quantidade();
            MediaAcertos mediaAcertos = new MediaAcertos();
            mediaAcertos.MediaAcertosPorObra(contadorRespostas);
            lblResultado.Text = contadorRespostas.Mensagem;
            lblMedia.Text = mediaAcertos.Mensagem;   
        }

        private void btnObra_Click(object sender, EventArgs e)
        {
            Apollo_11 Apollo_11 = new Apollo_11();
            Apollo_11.ShowDialog();
            this.Hide();
        }
    }
}
