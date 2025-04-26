using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Configuration;


namespace Regras_de_negócio {
    public static class Funcoes {
        public static void CriarLabel(Control container, string texto, string nome = "lblStatusEmail") {
            if (container.Controls[nome] == null) {
                Label lbl = new Label {
                    Name = nome,
                    Text = texto,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    ForeColor = Color.Blue,
                    Location = new Point(10, container.Height - 30)
                };
                container.Controls.Add(lbl);
                lbl.BringToFront();
            }
        }

        public static void RemoverLabel(Control container, string nome = "lblStatusEmail") {
            if (container.Controls[nome] != null) {
                container.Controls.RemoveByKey(nome);
            }
        }
    }

    public class EmailBLL {
        public static void EnviarEmailBLL(string mensagem, string destino, string assunto, Control mostrarMsgAguarde = null) {
            string emailRemetente = ConfigurationManager.AppSettings["EmailRemetente"];
            string senhaEmail = ConfigurationManager.AppSettings["SenhaEmail"];
            string nomeRemetente = ConfigurationManager.AppSettings["NomeRemetente"];
            string hostSMTP = ConfigurationManager.AppSettings["HostSMTP"];
            int portaSMTP = int.Parse(ConfigurationManager.AppSettings["PortaSMTP"]);

            try {
                using (SmtpClient smtp = new SmtpClient(hostSMTP, portaSMTP)) {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(emailRemetente, senhaEmail);

                    using (MailMessage msg = new MailMessage()) {
                        msg.From = new MailAddress(emailRemetente, nomeRemetente);
                        msg.To.Add(new MailAddress(destino));
                        msg.Subject = assunto;
                        msg.Body = mensagem;

                        if (mostrarMsgAguarde != null) {
                            Funcoes.CriarLabel(mostrarMsgAguarde, "Aguarde, enviando e-mail...", "Info");
                            mostrarMsgAguarde.Enabled = false;
                            mostrarMsgAguarde.Cursor = Cursors.WaitCursor;
                            Application.DoEvents();
                        }

                        smtp.Send(msg);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao enviar o e-mail:\r\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                if (mostrarMsgAguarde != null) {
                    Funcoes.RemoverLabel(mostrarMsgAguarde);
                    mostrarMsgAguarde.Enabled = true;
                    mostrarMsgAguarde.Cursor = Cursors.Default;
                }
            }
        }
 
    }
}
