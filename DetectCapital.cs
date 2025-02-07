﻿namespace DetectCapitalString
{
    public class DetectCapital
    {
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
