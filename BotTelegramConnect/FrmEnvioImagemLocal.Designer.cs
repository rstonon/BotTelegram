namespace BotTelegramConnect
{
    partial class FrmEnvioImagemLocal
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
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.TxtURLImagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscarImagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.Location = new System.Drawing.Point(12, 27);
            this.TxtMensagem.Multiline = true;
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.Size = new System.Drawing.Size(776, 161);
            this.TxtMensagem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mensagem:";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(618, 251);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(170, 45);
            this.BtnEnviar.TabIndex = 5;
            this.BtnEnviar.Text = "Enviar Mensagem";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // TxtURLImagem
            // 
            this.TxtURLImagem.Enabled = false;
            this.TxtURLImagem.Location = new System.Drawing.Point(12, 222);
            this.TxtURLImagem.Name = "TxtURLImagem";
            this.TxtURLImagem.Size = new System.Drawing.Size(695, 23);
            this.TxtURLImagem.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Caminho da Imagem";
            // 
            // BtnBuscarImagem
            // 
            this.BtnBuscarImagem.Location = new System.Drawing.Point(713, 222);
            this.BtnBuscarImagem.Name = "BtnBuscarImagem";
            this.BtnBuscarImagem.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarImagem.TabIndex = 8;
            this.BtnBuscarImagem.Text = "...";
            this.BtnBuscarImagem.UseVisualStyleBackColor = true;
            this.BtnBuscarImagem.Click += new System.EventHandler(this.BtnBuscarImagem_Click);
            // 
            // FrmEnvioImagemLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.BtnBuscarImagem);
            this.Controls.Add(this.TxtURLImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtMensagem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioImagemLocal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Imagem Local";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox TxtURLImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscarImagem;
    }
}