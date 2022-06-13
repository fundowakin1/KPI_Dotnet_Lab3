namespace Lab3.EncryptionTypes
{
    public interface ICypher
    {
        public string Encode(string value);
        public string Decode(string code);
    }
}
