using Lab3.EncryptionTypes;

namespace Lab3.Creators
{
    public abstract class PasswordEncrypter
    {
        public abstract ICypher CreateCypher();

        public string EncryptPassword(string text)
        {
            var cypher = CreateCypher();
            return cypher.Encode(text);
        }

        public string DecryptPassword(string text)
        {
            var cypher = CreateCypher();
            return cypher.Decode(text);
        }
    }
}
