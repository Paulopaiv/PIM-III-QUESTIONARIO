namespace TotemPIMApresentacao.View
{
    partial class ObraDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObraDocumentos));
            label2 = new Label();
            BtnTesteConhecimento = new Button();
            lblTextoObra = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(173, 218);
            label2.Name = "label2";
            label2.Size = new Size(668, 65);
            label2.TabIndex = 5;
            label2.Text = "DOCUMENTOS HISTÓRICOS ";
            // 
            // BtnTesteConhecimento
            // 
            BtnTesteConhecimento.Anchor = AnchorStyles.None;
            BtnTesteConhecimento.BackColor = SystemColors.Control;
            BtnTesteConhecimento.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTesteConhecimento.ForeColor = Color.FromArgb(64, 64, 64);
            BtnTesteConhecimento.Location = new Point(619, 866);
            BtnTesteConhecimento.Name = "BtnTesteConhecimento";
            BtnTesteConhecimento.Size = new Size(666, 73);
            BtnTesteConhecimento.TabIndex = 4;
            BtnTesteConhecimento.Text = "TESTE SEU CONHECIMENTO!\r\n";
            BtnTesteConhecimento.UseVisualStyleBackColor = false;
            BtnTesteConhecimento.Click += BtnTesteConhecimento_Click;
            // 
            // lblTextoObra
            // 
            lblTextoObra.Anchor = AnchorStyles.None;
            lblTextoObra.AutoSize = true;
            lblTextoObra.BackColor = Color.Transparent;
            lblTextoObra.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTextoObra.ForeColor = Color.White;
            lblTextoObra.Location = new Point(173, 302);
            lblTextoObra.Name = "lblTextoObra";
            lblTextoObra.Size = new Size(807, 500);
            lblTextoObra.TabIndex = 3;
            lblTextoObra.Text = resources.GetString("lblTextoObra.Text");
            lblTextoObra.TextAlign = ContentAlignment.MiddleLeft;
            lblTextoObra.UseMnemonic = false;
            // 
            // ObraDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1061);
            Controls.Add(label2);
            Controls.Add(BtnTesteConhecimento);
            Controls.Add(lblTextoObra);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ObraDocumentos";
            Text = "ObraSuits";
            Load += Atalho_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button BtnTesteConhecimento;
        private Label lblTextoObra;
    }
}