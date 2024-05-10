using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;
using static System.Windows.Forms.DataFormats;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace TotemPIMApresentacao.Controller
{
    internal class PerguntasFotos
    {

        private ObraFotos obraSuit;
        private ContadorRespostas contadorRespostas;
        private ResultadoFormFotos resultadosForm;
        private WinFormsTimer timer;
        private QuestionarioFotos questionarioForm;
        private string codigoUsuario;
        private int indicePergunta = 0;
        private string[] perguntas = {
            "Quem foi o astronauta responsável por tirar a famosa foto do Homem na Lua?",
            "Qual foi o formato principal das fotos tiradas durante a missão Apollo 11? ",
            "Que tipo de câmera foi usada para capturar a maioria das fotos da superfície lunar? ",
            "Quantas fotos foram tiradas durante a missão Apollo 11?",
            "Qual foi o formato principal dos vídeos gravados durante a missão Apollo 11? "
        };

        private string[][] alternativas = {

            new string[] { "A) Neil Armstrong",
                           "B) Buzz Aldrin", 
                           "C) Michael Collins", 
                           "D) Alan Shepard",
                           "E) John Glenn" }, // Resposta correta: B

            new string[] { "A) JPEG", 
                           "B)  PNG", 
                           "C) TIFF",
                           "D) GIF",
                           "E) BMP" }, // Resposta correta: C

            new string[] { "A) Hasselblad 500EL",
                           "B) Nikon D850", // Resposta correta: A
                           "C) Canon EOS 5D Mark IV",
                           "D) Sony Alpha a7S III",
                           "E) Leica M10" },

            new string[] { "A) Cerca de 100 ",
                           "B) Cerca de 500",
                           "C) Cerca de 1.000",
                           "D) Cerca de 1.500",
                           "E) Cerca de 2.000" }, // Resposta correta: D

            new string[] { "A) VHS", 
                           "B) Betamax",
                           "C) Super 8",
                           "D) 16mm film",
                           "E) Digital " } // Resposta correta: D
        };

        private int[] posicoesRespostasCorretas = { 1, 2, 0, 3, 3 };

        public PerguntasFotos(QuestionarioFotos questionarioForm, ContadorRespostas contadorRespostas, string codigoUsuario, string obra)
        {
            this.questionarioForm = questionarioForm;
            this.contadorRespostas = contadorRespostas;
            this.codigoUsuario = codigoUsuario;
            contadorRespostas.ObraAtual = obra;

            timer = new WinFormsTimer();
            timer.Interval = 4000;
            timer.Tick += Timer_Tick;
        }

        public ResultadoFormFotos ResultadoFormFotos
        {
            get => default;
            set
            {
            }
        }

        //public PerguntasFotos(QuestionarioFotos questionarioForm)
        //{
        //    this.questionarioForm = questionarioForm;
        //    timer = new WinFormsTimer();
        //    timer.Interval = 4000;
        //    timer.Tick += Timer_Tick;
        //   // contadorRespostas = new ContadorRespostas(posicoesRespostasCorretas);
        //}
        public void VerificarResposta(string respostaUsuario)
        {
            string respostaCorreta = ObterRespostaCorreta(indicePergunta);

            int posicaoRespostaUsuario = respostaUsuario[0] - 'A';

            if (posicaoRespostaUsuario == posicoesRespostasCorretas[indicePergunta])
            {
                contadorRespostas.Incrementar();
            }

        }

        private string ObterRespostaCorreta(int indice)
        {
            if (indice < posicoesRespostasCorretas.Length)
            {
                return alternativas[indice][posicoesRespostasCorretas[indice]].Substring(0, 1);
            }
            else
            {
                return ""; // Sem resposta correta para o índice fornecido
            }
        }

        public string PerguntaAtual()
        {
            if (indicePergunta < perguntas.Length)
            {
                return perguntas[indicePergunta];
            }
            else
            {
                timer.Start();
                resultadosForm = new ResultadoFormFotos(contadorRespostas);
                resultadosForm.ShowDialog();
                questionarioForm.Hide();
                return "";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            resultadosForm.Close();
            obraSuit = new ObraFotos();
            obraSuit.Show();
            timer.Stop();
        }
        public string[] AlternativasAtual()
        {
            if (indicePergunta < alternativas.Length)
            {
                return alternativas[indicePergunta];
            }
            else
            {
                return null;
            }
        }
        public void ProximaPergunta()
        {
            indicePergunta++;
        }
        public void AtualizarPergunta(Label lblPergunta, Label lblNumeroPergunta, Button[] botoesAlternativas)
        {
            lblNumeroPergunta.Text = "Pergunta " + (indicePergunta + 1);
            lblPergunta.Text = PerguntaAtual();
            string[] alternativas = AlternativasAtual();

            if (alternativas != null && alternativas.Length == 5 && botoesAlternativas.Length >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    botoesAlternativas[i].Text = alternativas[i];
                }
            }
        }


    }
}

