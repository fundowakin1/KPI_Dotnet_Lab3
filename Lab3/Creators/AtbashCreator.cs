using Lab3.EncryptionTypes;

namespace Lab3.Creators
{
    public class AtbashCreator : CypherCreator
    {
        public override ICypher CreateCypher()
        {
            return new AtbashCypher();
        }
    }
}
