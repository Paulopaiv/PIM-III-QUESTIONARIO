namespace TotemPIMApresentacao.View
{
    partial class ResultadoFormDocumentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoFormDocumentos));
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(700, 152);
            label2.Name = "label2";
            label2.Size = new Size(312, 37);
            label2.TabIndex = 6;
            label2.Text = "Resultado do Questionário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(681, 162);
            label3.Name = "label3";
            label3.Size = new Size(558, 128);
            label3.TabIndex = 7;
            label3.Text = "Parabéns!!!";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = SystemColors.Control;
            lblResultado.Location = new Point(541, 324);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(838, 86);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado do Questionário";
            // 
            // ResultadoFormDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1100);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResultadoFormDocumentos";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnObra;
        private Label label2;
        private Label label3;
        private Label lblResultado;
    }
}