using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemLocal : Form
    {
        public FrmEnvioImagemLocal()
        {
            InitializeComponent();
        }

        private Stream ToStream(Image imagem, ImageFormat formato)
        {
            var stream = new MemoryStream();
            imagem.Save(stream, formato);
            stream.Position = 0;

            return stream;
        }

        private async void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtURLImagem.Text.Trim()))
            {
                MessageBox.Show("Informe a URL da Imagem para envio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var bot = new TelegramBotClient("5436004966:AAGzm43341rJ0I5u2-1SK10MoaL2lXw-8eQ");

                using (var img = Image.FromFile(TxtURLImagem.Text.Trim()))
                {
                    var strem = ToStream(img, ImageFormat.Jpeg);

                    await bot.SendPhotoAsync(
                        chatId: "-1001539551274",
                        photo: strem,
                        caption: TxtMensagem.Text.Trim(),
                        parseMode: ParseMode.Html
                        );
                }

                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar a mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TxtMensagem.Text = String.Empty;
                TxtURLImagem.Text = String.Empty;
            }
        }

        private void BtnBuscarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\Users\rston\OneDrive\Desktop\BOTTelegram\";
                ofd.Filter = "Imagens (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TxtURLImagem.Text = ofd.FileName;
                }
            }
        }
    }
}
