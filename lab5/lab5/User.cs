using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class User
    {
        public delegate void VerifyEmail(object source, EventArgs args);
        public event VerifyEmail EmailVerified;
        public virtual void OnEmailVerified(string email)
        { if (EmailVerified != null)
            { EmailVerified(this, EventArgs.Empty); }  }
        
     public void OnEmailSent()
        {
            Console.WriteLine("¿Quiere verificar su correo?");
            string select = Console.ReadLine();
            switch(select)
            {
                case "si":
                    Console.WriteLine("Escriba su correo");
                    
                    string c = Console.ReadLine();
                    OnEmailVerified(c);
                    break;
                case "no":
                    break;

            }
        }
    }
}
