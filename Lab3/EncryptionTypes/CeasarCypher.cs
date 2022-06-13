using System.Text;
using Lab3.ValueConstants;

namespace Lab3.EncryptionTypes
{
    public class CeasarCypher : ICypher
    {
        private readonly int _key;
        public CeasarCypher(int key = 1)
        {
            _key = key;
        }
        public string Encode(string value)
        {
            return Encrypt(value, _key);
        }

        public string Decode(string code)
        {
            return Encrypt(code, -_key);
        }
        private string Encrypt(string text, int key)
        {
            var result = new StringBuilder(text.Length);
            var normalizedText = text.ToUpper();
            var letters = normalizedText.ToCharArray();
            var sign = GetOperator(key);
            var multiplier = Math.Abs(key/Alphabet.AlphabetString.Length);
            foreach (var letter in letters)
            {
                var index = Alphabet.AlphabetString.IndexOf(letter) + key;
                if (index < Alphabet.AlphabetString.Length && index >= 0)
                    result.Append(Alphabet.AlphabetString[index]);
                else
                    result.Append(Alphabet.AlphabetString[index - (Alphabet.AlphabetString.Length * sign * multiplier)]);
            }
            return result.ToString();
        }

        private int GetOperator(int key)
        {
            return key / Math.Abs(key) >= 0 ? 1 : -1;
        }
    }
}
