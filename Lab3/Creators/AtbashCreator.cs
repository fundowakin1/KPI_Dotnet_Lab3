using Lab3.EncryptionTypes;

namespace Lab3.Creators
{
    public class AtbashCreator : PasswordEncrypter
    {
        public override ICypher CreateCypher()
        {
            return new AtbashCypher();
        }
    }
}
