using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PasswordManager
{   interface Title
    {
        public void title();
    }
    
    interface Description
    {
        public void description();
    }

    interface Password
    {
        public void password();
    }

    interface UsernameToSave
    {
        public void usernametosave();
    }
    internal class DataBase : Title, Description, Password, UsernameToSave
    {
        public static string value1, value2, value3, value4;

        /*public DataBase()
        {
            value1 = "";
            value2 = "";
            value3 = "";
            value4 = "";
        }*/
        public void title()
        {
            Console.Write("\nEnter the Title: ");
            value1 = Console.ReadLine();
            
        }
        public void description () 
        {
            Console.Write("\nEnter the description: ");
            value2 = Console.ReadLine();
        }

        public virtual void password()
        {
            Console.Write("\nEnter the password: ");
            value3 = Console.ReadLine();
        }
        public void usernametosave() 
        {
            Console.Write("\nEnter the username to save for password: ");
            value4 = Console.ReadLine();
        }

        

        
    }
}
