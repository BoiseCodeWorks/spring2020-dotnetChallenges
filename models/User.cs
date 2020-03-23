namespace challenges.Models
{
    class User
    {
        public string UserName { get; set; }
        private string _password { get; set; }
        public bool LoggedIn { get; private set; }

        public bool ValidatePassword(string input)
        {
            if (_password == input)
            {
                LoggedIn = true;
            }
            return LoggedIn;
        }

        public User(string username, string password)
        {
            UserName = username;
            _password = password;
            LoggedIn = false;
        }
    }
}