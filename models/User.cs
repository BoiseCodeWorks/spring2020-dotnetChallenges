namespace challenges.Models
{
    class User
    {
        public string UserName { get; set; }
        private string _password { get; set; }

        public bool ValidatePassword(string input)
        {
            return _password == input;
        }

        public User(string username, string password)
        {
            UserName = username;
            _password = password;
        }
    }
}