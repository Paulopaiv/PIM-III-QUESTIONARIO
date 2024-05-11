
using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace TotemPIMApresentacao.Controller
{
    internal class PerguntasHistoria
    {

        private ObraHistoria obraEquip;
        private ContadorRespostas contadorRespostas;
        private ResultadoFormHistoria resultadosForm;
        private WinFormsTimer timer;
        private QuestionarioHistoria questionarioForm;
        private string codigoUsuario;

        private int indicePergunta = 0;
        private string[] perguntas = {
            "Qual foi o presidente dos Estados Unidos que anunciou o objetivo de pousarna Lua?", //1
            "Em que ano a missão Apollo 11 foi lançada?", //2
            "Qual foi o nome da corrida espacial entre os Estados Unidos e a União Soviética?", //3
            "Além dos Estados Unidos, qual outro país enviou uma missão tripulada à Lua?", //4
            "Qual foi o nome do primeiro ser humano a viajar para o espaço, em 1961?" //5
        };

        private string[][] alternativas = {
            new string[] { "A) John F. Kennedy",
                            "B) Lyndon B. Johnson ",
                            "C) Richard Nixon ",
                            "D) Dwight D. Eisenhower ",
                            "E) Gerald Ford" }, // Resposta correta: A
          
            new string[] { "A) 1967",
                            "B) 1968",
                            "C) 1969",
                            "D) 1970",
                            "E) 1971" }, // Resposta correta: C
         
            new string[] { "A) Corrida Armamentista " ,
                            "B) Guerra Fria Espacial ", // Resposta correta: D
                            "C) Corrida Lunar",
                            "D) Corrida Espacial",
                            "E) Corrida Tecnológica" },

            new string[] { "A) União Soviética",
                           "B) China  ",
                           "C) Índia",
                           "D) Japão",
                           "E) Alemanha" }, // Resposta correta: A


            new string[] { "A) Yuri Gagarin ",
                           "B) Neil Armstrong",
                           "C) Buzz Aldrin  ",
                            "D) Alan Shepard ",
                           "E) John Glenn" } // Resposta correta: A
        };

        private int[] posicoesRespostasCorretas = { 0, 2, 3, 0, 0 };

        public PerguntasHistoria(QuestionarioHistoria questionarioForm, ContadorRespostas contadorRespostas, string codigoUsuario, string obra)
        {
            this.questionarioForm = questionarioForm;
            this.contadorRespostas = contadorRespostas;
            this.codigoUsuario = codigoUsuario;
            contadorRespostas.ObraAtual = obra;

            timer = new WinFormsTimer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
        }

        public ResultadoFormHistoria ResultadoFormHistoria
        {
            get => default;
            set
            {
            }
        }

        //public PerguntasHistoria(QuestionarioHistoria questionarioForm)
        //{
        //    this.questionarioForm = questionarioForm;
        //    timer = new WinFormsTimer();
        //    timer.Interval = 4000;
        //    timer.Tick += Timer_Tick;
        //    //contadorRespostas = new ContadorRespostas(posicoesRespostasCorretas);
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
                resultadosForm = new ResultadoFormHistoria(contadorRespostas);
                resultadosForm.ShowDialog();
                questionarioForm.Hide();
                return "";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            resultadosForm.Close();
            obraEquip = new ObraHistoria();
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

