using System.Text;
using Lab3.ValueConstants;

namespace Lab3.EncryptionTypes
{
    public class AtbashCypher : ICypher
    {
        public string Encode(string value)
        {
            return Encrypt(value, Alphabet.AlphabetString, Alphabet.ReversedAlphabetString);
        }

        public string Decode(string code)
        {
            return Encrypt(code, Alphabet.ReversedAlphabetString, Alphabet.AlphabetString);
        }

        private string Encrypt(string text, string alphabet, string reversedAlphabet)
        {
            var result = new StringBuilder(text.Length);
            var normalizedText = text.ToUpper();
            var letters = normalizedText.ToCharArray();

            foreach (var letter in letters)
                result.Append(reversedAlphabet[alphabet.IndexOf(letter)]);

            return result.ToString();
        }
    }
}
