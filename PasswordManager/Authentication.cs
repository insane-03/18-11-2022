using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignIn;
namespace PasswordManager
{
    internal class Authentication
    {
        string input;
        int ID = 0;

        static string[] usernameArray = File.ReadAllLines(@"C:\Users\GowthamM\source\repos\PasswordManager\username.txt");//loads a text file and sets it to an array
        ArrayList username = new ArrayList(usernameArray);//sets the array to an array list
        static string[] passcodeArray = File.ReadAllLines(@"C:\Users\GowthamM\source\repos\PasswordManager\passcode.txt");
        ArrayList passcode = new ArrayList(passcodeArray);
        public void Signin()
        {
            Console.Clear();
            Console.Write("\nWhat is your user name? :");
            input = Console.ReadLine();
            input = input.ToLower();
            foreach (string name in username)//runs through the username list
            {
                if (name == input)//returns true if it finds a match in the list
                {
                    int listNo = username.IndexOf(input);//sets the listNo to the index number of the password list that matched
                    Console.Write("\nWhat is your passcode? :");
                    input = Console.ReadLine();
                    string passCheck = Convert.ToString(passcode[listNo]);//sets the passCheck var to the string index no found at the same index as the user name
                    if (input == passCheck) //if the input and the passCheck are the same you logged in
                    {
                        ID = listNo;//sets the ID for the user
                        Console.Clear() ;
                        Console.WriteLine("\nYou logged in!");

                        //Console.ReadKey();
                        MainProcess mp = new MainProcess();
                        mp.MP();
                        
                    }
                }
            }
            Console.WriteLine("\nSorry there was some error!");
            Console.ReadKey();
        }

        public void Signout()
        {
            string input;
            Console.Write("\nWould you like to logout? y/n :");
            input = Console.ReadLine();
            if (input == "y")
            {
                Console.WriteLine("\nLogged out");
                Console.WriteLine("\nShutting down");
                Console.ReadKey();
            }
            Console.Clear();
            Environment.Exit(0);
           
            
            
        }
    }
}
