namespace TotemPIMApresentacao.View
{
    partial class LoginEquip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginEquip));
            txbCodigoVisitante = new TextBox();
            BtnEntrar = new Button();
            lblNome = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txbCodigoVisitante
            // 
            txbCodigoVisitante.Anchor = AnchorStyles.Right;
            txbCodigoVisitante.BorderStyle = BorderStyle.FixedSingle;
            txbCodigoVisitante.ForeColor = SystemColors.ActiveCaptionText;
            txbCodigoVisitante.Location = new Point(20, 41);
            txbCodigoVisitante.Name = "txbCodigoVisitante";
            txbCodigoVisitante.Size = new Size(374, 23);
            txbCodigoVisitante.TabIndex = 2;
            txbCodigoVisitante.Click += TextBox1_Click;
            // 
            // BtnEntrar
            // 
            BtnEntrar.Anchor = AnchorStyles.Right;
            BtnEntrar.BackColor = Color.White;
            BtnEntrar.Cursor = Cursors.Hand;
            BtnEntrar.FlatAppearance.BorderSize = 0;
            BtnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEntrar.ForeColor = Color.Black;
            BtnEntrar.Location = new Point(94, 89);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(227, 57);
            BtnEntrar.TabIndex = 3;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = false;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.Gainsboro;
            lblNome.Location = new Point(20, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(148, 25);
            lblNome.TabIndex = 14;
            lblNome.Text = "Token Visitante";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BtnEntrar);
            panel1.Controls.Add(txbCodigoVisitante);
            panel1.Controls.Add(lblNome);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(755, 439);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 168);
            panel1.TabIndex = 15;
            // 
            // LoginEquip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1100);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginEquip";
            Text = "LoginVisitante";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txbNomeCompleto;
        private TextBox txbCodigoVisitante;
        private Button BtnEntrar;
        private Label lblNome;
        private Panel panel1;
    }
}