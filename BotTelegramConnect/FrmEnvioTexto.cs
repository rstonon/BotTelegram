using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioTexto : Form
    {
        public FrmEnvioTexto()
        {
            InitializeComponent();
        }

        private async void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtMensagem.Text.Trim()))
            {
                MessageBox.Show("Informe a mensagem para envio.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var bot = new TelegramBotClient("5436004966:AAGzm43341rJ0I5u2-1SK10MoaL2lXw-8eQ");

                await bot.SendTextMessageAsync(
                    chatId: "-1001539551274",
                    text: TxtMensagem.Text.Trim(),
                    parseMode: ParseMode.Html
                    );

                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar a mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TxtMensagem.Text = String.Empty;
            }
        }
    }
}
