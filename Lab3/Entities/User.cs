using Lab3.Creators;

namespace Lab3.Entities
{
    public class User
    {
        private string _encryptedPassword;
        private readonly CypherCreator _creator;
        public string Username { get; set; }

        public User(CypherCreator creator)
        {
            _creator ??= creator;
        }
        public void SetPassword(string password)
        {
            _encryptedPassword = _creator.Encrypt(password);
        }

        public string GetPassword()
        {
            if (_encryptedPassword == null)
                throw new NullReferenceException("The password is not set");

            return _creator.Decrypt(_encryptedPassword);
        }

        public override string ToString()
        {
            return $"Username: {Username} \tEncrypted password: {_encryptedPassword}";
        }
    }
}
