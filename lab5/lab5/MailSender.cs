using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class MailSender
    {

        public delegate void SendMail(object source, EventArgs args);
        public event SendMail EmailSent;
        public virtual void OnEmailSent(string email)
        { if (EmailSent!=null)
            { EmailSent(this, EventArgs.Empty); }
        }
        public void OnRegistered(object source, RegisterEventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: {e.VerificationLink}\n");
            System.Threading.Thread.Sleep(2000);
            OnEmailSent(e.Email);
        }

        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
