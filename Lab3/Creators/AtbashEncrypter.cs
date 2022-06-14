using Lab3.EncryptionTypes;

namespace Lab3.Creators
{
    public class AtbashEncrypter : PasswordEncrypter
    {
        public override ICypher CreateCypher()
        {
            return new AtbashCypher();
        }
    }
}
