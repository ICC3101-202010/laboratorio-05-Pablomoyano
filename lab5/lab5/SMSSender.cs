using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class SMSSender
    {
        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"\nSMS enviado a {e.Number}: \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
