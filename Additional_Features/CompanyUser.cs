using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    public class CompanyUser
    {
        public CompanyUser(string name) : this(name, username, SecretQuestion, secret, "Jlk.05235.22")
        {

        }
        public CompanyUser(string name, string username, string question, string SecretQuestion, string pass)
        {


            Name = name;
            UserName = username;
            UserPassword = pass;

            SecretAnswer = secret;
        }

        const string SecretQuestion = "What is your mothers maiden name?";
        string SecretAnswer { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string UserPassword { get; set; }
        public static string username { get; private set; }
        public static string secret { get; private set; }
    }
}
