using Lab3.EncryptionTypes;

namespace Lab3.Creators
{
    public abstract class CypherCreator
    {
        public abstract ICypher CreateCypher();

        public string Encrypt(string text)
        {
            var cypher = CreateCypher();
            return cypher.Encode(text);
        }

        public string Decrypt(string text)
        {
            var cypher = CreateCypher();
            return cypher.Decode(text);
        }
    }
}
