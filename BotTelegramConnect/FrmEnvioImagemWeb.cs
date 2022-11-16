using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using System.Net;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemWeb : Form
    {
        public FrmEnvioImagemWeb()
        {
            InitializeComponent();
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

                var imagemRequest = WebRequest.Create(TxtURLImagem.Text.Trim());

                using (var imagemResponse = imagemRequest.GetResponse())
                {
                    var strem = imagemResponse.GetResponseStream();

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
    }
}
