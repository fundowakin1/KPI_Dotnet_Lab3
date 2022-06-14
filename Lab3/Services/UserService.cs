using Lab3.Creators;
using Lab3.Entities;

namespace Lab3.Services
{
    internal class UserService
    {
        private readonly User _user;
        private readonly PasswordEncrypter _passwordEncrypter;

        public UserService(User user, PasswordEncrypter passwordEncrypter)
        {
            _user = user;
            _passwordEncrypter = passwordEncrypter;
        }

        public void SetPassword(string password)
        {
            _user.EncryptedPassword = _passwordEncrypter.EncryptPassword(password);
        }

        public string GetPassword()
        {
            if (_user.EncryptedPassword == null)
                throw new NullReferenceException("The password is not set");

            return _passwordEncrypter.DecryptPassword(_user.EncryptedPassword);
        }
    }
}
