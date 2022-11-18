
namespace PasswordManager
{
    internal class Program


    {
        static void Main(string[] args)
        {
            string input;
            int ID = 0;
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>----------------PASSWORD MANAGER-----------------<<<<<<<<<<<<<<<<<<\n\n");
            

            
            Console.WriteLine("------ Main menu --------");
            Console.Write("\n1 login\n2 Register\n3 Shutdown\n\n Enter your choice:");
            input = Console.ReadLine();
            input.ToLower();

            Authentication authentication = new Authentication();
            Register reg = new Register();


            switch (input)
            {
                case "1":
                case "login":
                    authentication.Signin();
                    break;
                case "2":
                case "register":
                    reg.RegisterUser();
                    break;
                case "4":
                case "passcode reset":
                    reg.PasscodeRest();
                    break;
                case "3":
                case "shutdown":
                    authentication.Signout();
                    break;
                default:
                    Console.Write("\nUnexpected input");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
