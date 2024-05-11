
using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace TotemPIMApresentacao.Controller
{
    internal class PerguntasReplica
    {

        private ObraReplica obraEquip;
        private ContadorRespostas contadorRespostas;
        private ResultadoFormReplica resultadosForm;
        private WinFormsTimer timer;
        private QuestionarioReplica questionarioForm; 
        private string codigoUsuario;

        private int indicePergunta = 0;
        private string[] perguntas = {
            "Qual era o principal objetivo da nave Apollo 11 durante a missão à Lua?", //1
            "Quantos estágios principais tinha a nave Apollo 11?", //2
            "Qual era o nome do módulo que permanecia em órbita enquanto o módulo lunar pousava na Lua?", //3
            "Como era chamado o foguete que lançou a nave Apollo 11 ao espaço? ", //4
            "Qual era a capacidade máxima de tripulação da nave Apollo 11?" //5
        };

        private string[][] alternativas = {
            new string[] { "A) Pousar na Lua e coletar amostras ",
                            "B) Orbitar a Lua e fotografar a superfície ",
                            "C) Estudar a radiação no espaço profundo ",
                            "D) Testar novas tecnologias de propulsão ",
                            "E) Realizar experimentos científicos na órbita lunar" }, // Resposta correta: A 0 
          
            new string[] { "A) Dois",
                            "B) Três",
                            "C) Quatro",
                            "D) Cinco",
                            "E) Seis" }, // Resposta correta: B 1
         
            new string[] { "A) Módulo de Comando  " ,
                            "B) Módulo Lunar  ", // Resposta correta: A 0
                            "C) Módulo de Serviço",
                            "D) Módulo de Aterrissagem ",
                            "E) Módulo de Retorno" },

            new string[] { "A) Saturn V ",
                           "B) Atlas-Agena ",
                           "C) Titan II",
                           "D) Delta II ",
                           "E) Falcon 9" }, // Resposta correta: A 0 


            new string[] { "A)  Dois astronautas ",
                           "B) Três astronautas",
                           "C) Quatro astronautas",
                            "D) Cinco astronautas",
                           "E) Seis astronautas" } // Resposta correta: B 1
        };

        private int[] posicoesRespostasCorretas = { 0, 1, 0, 0, 1 };

        public PerguntasReplica(QuestionarioReplica questionarioForm, ContadorRespostas contadorRespostas, string codigoUsuario, string obra)
        {
            this.questionarioForm = questionarioForm;
            this.contadorRespostas = contadorRespostas;
            this.codigoUsuario = codigoUsuario;
            contadorRespostas.ObraAtual = obra;

            timer = new WinFormsTimer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
        }

        public ResultadoFormReplica ResultadoFormReplica
        {
            get => default;
            set
            {
            }
        }

        //public PerguntasReplica(QuestionarioReplica questionarioForm)
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
                resultadosForm = new ResultadoFormReplica(contadorRespostas);
                resultadosForm.ShowDialog();
                questionarioForm.Hide();
                return "";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            resultadosForm.Close();
            obraEquip = new ObraReplica();
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

