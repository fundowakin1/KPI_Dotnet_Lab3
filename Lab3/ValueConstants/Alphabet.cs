namespace Lab3.ValueConstants
{
    public class Alphabet
    {
        public static readonly string AlphabetString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static readonly string ReversedAlphabetString = AlphabetString.Aggregate("", (x, y) => y + x);

    }           
}               
                