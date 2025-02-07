namespace DetectCapitalString
{
    /// <summary>
    /// Class that verifies whether a word follows correct capitalization rules.
    /// </summary>
    public class DetectCapital
    {
        /// <summary>
        /// Checks if the given word uses capitalization correctly.
        /// </summary>
        /// <param name="word">The input word consisting of uppercase and lowercase letters.</param>
        /// <returns>Returns true if the word follows valid capitalization rules; otherwise, returns false.</returns>
        public static bool DetectCapitalUse(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;

            if (word.ToUpper() == word || 
                word.ToLower() == word ||
                char.IsUpper(word[0]) && word.Substring(1).ToLower() == word.Substring(1)) return true;

            return false;
        }
    }
}
