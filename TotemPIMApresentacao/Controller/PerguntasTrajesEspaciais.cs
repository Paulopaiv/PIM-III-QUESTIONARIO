
using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace TotemPIMApresentacao.Controller
{
    internal class PerguntasTrajesEspaciais
    {

        private ObraSuits obraSuit;
        private ContadorRespostas contadorRespostas;
        private ResultadoFormSuit resultadosForm;
        private WinFormsTimer timer;
        private QuestionarioSuits questionarioForm;
        private int indicePergunta = 0;
        private string[] perguntas = {
            "Qual era o nome do traje espacial usado pelos astronautas da Apollo 11?",
            "Quantas camadas tinha o traje espacial utilizado na missão Apollo 11?",
            "Qual era a função da camada externa do traje espacial?",
            "Como eram chamadas as luvas dos trajes espaciais da Apollo 11? ",
            "Qual era o principal desafio enfrentado pelos astronautas em relação aos trajes? "
        };

        private string[][] alternativas = {

            new string[] { "A) AstroSuit",
                           "B) SpaceGuard",
                           "C) LunarSuit", 
                           "D) Extravehicular Mobility Unit (EMU) ",
                           "E) SpaceWalker" }, // Resposta correta: D

            new string[] { "A) Uma camada",
                           "B)  Duas camadas ", 
                           "C) Três camadas ",
                           "D) Quatro camadas ",
                           "E) Cinco camadas " }, // Resposta correta: C

            new string[] { "A) Isolamento térmico",
                           "B) Proteção contra micro meteoroides", // Resposta correta: B
                           "C) Controle de umidade",
                           "D) Suporte de vida ",
                           "E) Comunicação"},

            new string[] { "A) GloveSuits",
                           "B) AstroGloves",
                           "C) LunarGloves",
                           "D) EVA Gloves",
                           "E) Space Gloves " }, // Resposta correta: D

            new string[] { "A) Regulação de temperatura",
                           "B Movimentação restrita",
                           "C) Falta de oxigênio",
                           "D) Visibilidade limitada",
                           "E) Peso excessivo" } // Resposta correta: B
        };

        private int[] posicoesRespostasCorretas = { 3, 2, 1, 3, 1 };

        public PerguntasTrajesEspaciais(QuestionarioSuits questionarioForm)
        {
            this.questionarioForm = questionarioForm;
            timer = new WinFormsTimer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            contadorRespostas = new ContadorRespostas(posicoesRespostasCorretas);
        }
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
                resultadosForm = new ResultadoFormSuit(contadorRespostas);
                resultadosForm.ShowDialog();
                questionarioForm.Hide();
                return "";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            resultadosForm.Close();
            obraSuit = new ObraSuits();
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

