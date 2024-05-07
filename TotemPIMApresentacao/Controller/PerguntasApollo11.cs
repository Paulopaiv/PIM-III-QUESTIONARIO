using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace TotemPIMApresentacao.Controller
{
    public class PerguntasApollo11
    {
        
        private Apollo_11 apollo;
        private ContadorRespostas contadorRespostas;
        private ResultadoForm resultadosForm;
        private WinFormsTimer timer;
        private QuestionarioForm questionarioForm;
        private int indicePergunta = 0;
        private string[] perguntas = {
            "Qual era o nome do módulo lunar usado na missão Apollo 11?",
            "Quantos astronautas a nave Apollo 11 levou para a Lua?",
            "Qual foi o papel do módulo lunar na missão Apollo 11?",
            "Qual era o nome do primeiro astronauta a pisar na Lua a bordo do módulo lunar?",
            "Como o módulo lunar retornou à órbita lunar após a missão na superfície?"
        };

        private string[][] alternativas = {

            new string[] { "A) Eagle",
                           "B) Falcon",
                           "C) Hawk",
                           "D) Sparrow",
                           "E) Osprey" }, // Resposta correta: A

            new string[] { "A) Quatro",
                           "B) Dois",
                           "C) Três",
                           "D) Cinco",
                           "E) Seis" }, // Resposta correta: C

            new string[] { "A) Orbitar a Lua e transmitir dados para a Terra ",
                           "B)Transportar astronautas até a Lua e mantê-los seguros ", // Resposta correta: B

                           "C) Pousar na Lua e retornar à órbita lunar",
                           "D) Explorar a superfície lunar em busca de recursos",
                           "E) Construir uma base lunar para futuras missões" },
            new string[] { "A) Neil Armstrong",
                           "B) Buzz Aldrin",
                           "C) Michael Collins",
                           "D) Alan Shepard",
                           "E) John Glenn" }, // Resposta correta: A

            new string[] { "A) Não retornou à órbita, permanecendo na superfície lunar ",
                           "B) Utilizou foguetes auxiliares para retornar à órbita",
                           "C) Foi empurrado por astronautas para voltar à órbita",
                           "D) Aterrissou em uma área predestinada para ser recuperado posteriormente",
                           "E)Decolou da superfície lunar e se acoplou ao módulo de comando" } // Resposta correta: E
        };

        private int[] posicoesRespostasCorretas = { 0, 2, 1, 0, 4 };

        public PerguntasApollo11(QuestionarioForm questionarioForm)
        {
            this.questionarioForm = questionarioForm;
            timer = new WinFormsTimer();
            timer.Interval = 4000;
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
                resultadosForm = new ResultadoForm(contadorRespostas);
                resultadosForm.ShowDialog();
                questionarioForm.Hide();
                return "";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            resultadosForm.Close();
            apollo = new Apollo_11();
            apollo.Show();
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