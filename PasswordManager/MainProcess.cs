using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SignIn;
using SignUp;
using PassReset;

namespace PasswordManager
{
    internal class MainProcess:DataBase
    {
        //DataBase mp = new DataBase();
        Authentication authentication= new Authentication();

        public override void password()
        {
            Console.Write("\nEnter the password to confirm: ");
            value3 = Console.ReadLine();
        }
        private void FormUpdate()
        {
            title();
            description();
            usernametosave();
            base.password();
            password();
        }
        private void FormView()
        {
            Console.Write("\nTitle: "+value1);
            Console.Write("\nDescription: "+value2);
            Console.Write("\nUsername: "+value4);
            Console.Write("\nPassword: "+value4);
        }
        public void MP()
        {
            do
            {
                string input;
                Console.WriteLine("------- form menu----------");
                Console.Write("\n1 View\n2 Update \n3 Shutdown\n Enter your choice:");
                input = Console.ReadLine();
                input.ToLower();

                switch (input)
                {
                    case "1":
                    case "view":
                        FormView();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                    case "update":
                        FormUpdate();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                    case "shutdown":
                        authentication.Signout();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nUnexpected input");
                        Console.ReadKey();
                        break;

                }

            }while(true);
        }
        

        
    }
}
