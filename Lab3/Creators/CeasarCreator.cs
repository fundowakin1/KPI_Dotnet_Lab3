using Lab3.EncryptionTypes;

namespace Lab3.Creators
{
    public class CeasarCreator : CypherCreator
    {
        private readonly int _key;

        public CeasarCreator(int key = 1)
        {
            _key = key;
        }
        public override ICypher CreateCypher()
        {
            return new CeasarCypher(_key);
        }
    }
}
