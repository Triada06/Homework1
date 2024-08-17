using System.Diagnostics;

namespace Homework
{
    internal class User
    {
        private string userName;
        public string UserName
        {
            get { return userName; }
            set 
            {
                if (value.Length > 6 && value.Length < 25) { userName = value; }
            }
        }

        private string  password;

        public string  Password
        {
            get { return password; }
            set 
            {
                if (value.Length > 8 && value.Length < 25)
                {
                    bool hasUpperCase = false;
                    bool hasLowerCase = false;

                    foreach (char c in value)
                    {
                        if (c >= 65 && c <= 90) hasUpperCase = true;
                            
                        else if (c >= 97 && c <= 122) hasLowerCase = true;

                        if (hasUpperCase && hasLowerCase) break;
                    }
                    if(hasUpperCase && hasLowerCase)
                    password = value;
                }
            }
        }


        public bool HasDigit(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if(char.IsDigit(line[i])) return true;
               
            }
            return false;
        }

        public bool HasUpper(string line)
        {
            foreach (var item in line)
            {
                if (item >= 65 && item <= 90) 
                {
                    return true;
                }
            }
            return false;
        }



        public bool HasLower(string line)
        {
            foreach (var item in line)
            {
                if (item >= 97 && item <= 122) return true;
            }

            return false;
        }

    }
}
