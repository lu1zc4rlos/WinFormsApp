using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regras_de_negócio {

    public static class Funcoes {

        public static void CriarLabel(Control container, string texto, string nome = "lblStatusEmail") {
           
            if (container.Controls[nome] == null) {
                Label lbl = new Label();
                lbl.Name = nome;
                lbl.Text = texto;
                lbl.AutoSize = true;
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Italic);
                lbl.ForeColor = Color.Blue;
                lbl.Location = new Point(10, container.Height - 30); 
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

            using (SmtpClient smtp = new SmtpClient()) {
                smtp.Host = "smtp.gmail.com";
               // smtp.Host = "smtp.office365.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                smtp.Credentials = new NetworkCredential("luiz.programa.carlos@gmail.com", "iilg xuxm yqbq iqgj");

                using (MailMessage msg = new MailMessage()) {
                    msg.From = new MailAddress("luiz.programa.carlos@gmail.com", "AtendeTech");
                    msg.To.Add(new MailAddress(destino));
                    msg.Subject = assunto;
                    msg.Body = mensagem;

                    try {
                        if (mostrarMsgAguarde != null) {
                            Funcoes.CriarLabel(mostrarMsgAguarde, "Aguarde, enviando e-mail...", "Info");
                            mostrarMsgAguarde.Enabled = false;
                            mostrarMsgAguarde.Cursor = Cursors.WaitCursor;
                            Application.DoEvents();
                        }

                        smtp.Send(msg);
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
    }
}
