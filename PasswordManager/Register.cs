using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUp;
namespace PasswordManager
{
    internal class Register
    {
        string input; //
        int ID = 0;
        static string[] usernameArray = File.ReadAllLines(@"C:\Users\GowthamM\source\repos\PasswordManager\username.txt");//loads a text file and sets it to an array
        ArrayList username = new ArrayList(usernameArray);//sets the array to an array list
        static string[] passcodeArray = File.ReadAllLines(@"C:\Users\GowthamM\source\repos\PasswordManager\passcode.txt");
        ArrayList passcode = new ArrayList(passcodeArray);
        public void RegisterUser()
        {
            Console.Write("\nWhat would you like your user name to be? :");
        
            input = Console.ReadLine();
            input = input.ToLower();
            if (input == "")
            {
                Console.Write("\nPlease input a username");
                
            }
            foreach (string name in username)
            {
                if (name == input)//checks if there is a user name called that already
                {
                    Console.Write("\nSorry this username is taken");
                    Console.ReadKey();
                    
                }
            }
            username.Add(input);//adds the username to the username list
            Console.Write("\nWhat would you like your password to be?");
        
            input = Console.ReadLine();
            if (input == "")
            {
                Console.Write("\nPlease enter a password");
                
            }
            passcode.Add(input);//adds the password to the password list
            using (TextWriter writer = File.CreateText(@"C:\Users\GowthamM\source\repos\PasswordManager\username.txt"))//creates a txt file called username
            {
                foreach (string name in username)
                {
                    writer.WriteLine(name);//adds a new line to the txt file for the user
                }
            }
            using (TextWriter writer = File.CreateText(@"C:\Users\GowthamM\source\repos\PasswordManager\passcode.txt"))
            {
                foreach (string pass in passcode)
                {
                    writer.WriteLine(pass);
                }
            }
            
            Console.Write("\nUser created!");
            Console.ReadKey();
        }

        public void PasscodeRest()
        {
            Console.Write("\nWhat would you like your new password to be?");
            input = Console.ReadLine();
            passcode[ID] = input;
            using (TextWriter writer = File.CreateText(@"passcode.txt"))
            {
                foreach (string pass in passcode)
                {
                    writer.WriteLine(pass);
                }
            }
            Console.Write("\nPassword changed!");
            Console.ReadKey();
        }
    }
}
