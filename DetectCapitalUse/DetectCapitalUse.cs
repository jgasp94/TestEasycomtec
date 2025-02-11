namespace DetectCapitalUse
{
    public static class DetectCapitalUse
    {
        public static bool Run(string word)
        {
            if (1 <= word.Length && word.Length <= 100)
            {
                if (word.All(c => char.IsUpper(c)) || word.All(c => char.IsLower(c)))
                    return true;

                return char.IsUpper(word[0]) ? word.Skip(1).All(x => char.IsLower(x)) : false;
            }
            else
                return false;
        }
    }
}
