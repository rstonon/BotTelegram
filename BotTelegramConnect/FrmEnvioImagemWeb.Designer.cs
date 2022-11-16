namespace BotTelegramConnect
{
    partial class FrmEnvioImagemWeb
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtURLImagem = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagem:";
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.Location = new System.Drawing.Point(12, 27);
            this.TxtMensagem.Multiline = true;
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.Size = new System.Drawing.Size(776, 161);
            this.TxtMensagem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL da Imagem:";
            // 
            // TxtURLImagem
            // 
            this.TxtURLImagem.Location = new System.Drawing.Point(12, 223);
            this.TxtURLImagem.Name = "TxtURLImagem";
            this.TxtURLImagem.Size = new System.Drawing.Size(776, 23);
            this.TxtURLImagem.TabIndex = 3;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(618, 252);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(170, 45);
            this.BtnEnviar.TabIndex = 4;
            this.BtnEnviar.Text = "Enviar Mensagem";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // FrmEnvioImagemWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtURLImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMensagem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioImagemWeb";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mensagem com Imagem da Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtURLImagem;
        private System.Windows.Forms.Button BtnEnviar;
    }
}