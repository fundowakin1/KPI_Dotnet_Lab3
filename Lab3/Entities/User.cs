using Lab3.Creators;

namespace Lab3.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string EncryptedPassword { get; set; }
        public override string ToString()
        {
            return $"Username: {Username} \tEncrypted password: {EncryptedPassword}";
        }
    }
}
