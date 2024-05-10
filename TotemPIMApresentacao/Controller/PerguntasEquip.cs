using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;
using static System.Windows.Forms.DataFormats;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace TotemPIMApresentacao.Controller
{
    internal class PerguntasEquip
    {

        private ObraEquip obraEquip;
        private ContadorRespostas contadorRespostas;
        private ResultadoFormEquip resultadosForm;
        private WinFormsTimer timer;
        private QuestionarioEquip questionarioForm;
        private string codigoUsuario;
        private int indicePergunta = 0;
        private string[] perguntas = {
            "Qual era o nome do computador utilizado na nave Apollo 11 durante a missão à Lua? ", //1
            "Que tipo de câmeras foram usadas para documentar a missão Apollo 11? ? ", //2
            "Qual era a principal função dos dispositivos de comunicação na Apollo 11?  ", //3
            "Além do computador de bordo, quais eram os outros tipos utilizados na missão? ", //4
            "Que tipo de instrumentos foram usados para medir a posição da nave durante a missão?  " //5
        };

        private string[][] alternativas = {

            new string[] { "A) Apollo Central Computer (ACC)",
                           "B) Lunar Module Guidance Computer (LMGC)",
                           "C) Apollo Guidance Computer (AGC)", // Resposta correta: C
                           "D) Lunar Module Central Computer (LMCC)",
                           "E) Spacecraft Computer System (SCS)" }, 

            new string[] { "A) Câmeras digitais",
                           "B)  Câmeras de filme 35mm", 
                           "C) Câmeras de filme 16mm", // Resposta correta: C
                           "D) Câmeras de vídeo analógico",
                           "E)  Câmeras infravermelhas" }, 

            new string[] { "A) Transmitir dados para a Terra" ,
                           "B) Facilitar a comunicação entre astronautas", // Resposta correta: B
                           "C) Receber instruções da NASA",
                           "D) Monitorar a saúde dos astronautas",
                           "E) Controlar os sistemas da nave" },

            new string[] { "A) Computadores pessoais",
                           "B) Computadores de backup",
                           "C) Computadores de controle de missão", // Resposta correta: C
                           "D) Computadores de navegação",
                           "E) Computadores de comunicação" }, 

            new string[] { "A) Radares",
                           "B) Giroscópios",
                           "C) Acelerômetros", // Resposta correta: C
                           "D) Telescópios",
                           "E) Magnetômetros" } 
        };

        private int[] posicoesRespostasCorretas = { 2, 2, 1, 2, 2 };

        public PerguntasEquip(QuestionarioEquip questionarioForm, ContadorRespostas contadorRespostas, string codigoUsuario, string obra)
        {
            this.questionarioForm = questionarioForm;
            this.contadorRespostas = contadorRespostas;
            this.codigoUsuario = codigoUsuario;
            contadorRespostas.ObraAtual = obra;

            timer = new WinFormsTimer();
            timer.Interval = 4000;
            timer.Tick += Timer_Tick;
        }

        public ResultadoFormEquip ResultadoFormEquip
        {
            get => default;
            set
            {
            }
        }

        //public PerguntasEquip(QuestionarioEquip questionarioForm)
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
                resultadosForm = new ResultadoFormEquip(contadorRespostas);
                resultadosForm.ShowDialog();
                questionarioForm.Hide();
                return "";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            resultadosForm.Close();
            obraEquip = new ObraEquip();
            obraEquip.Show();
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

