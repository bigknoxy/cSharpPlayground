namespace GoofingAround.StringHelpers;

public static class StringHelpers
{
    public static string ReverseCase(this string s)
    {
        char[] tempChars = new char[s.Length];
        char[] charArray = s.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (Char.IsLetter(charArray[i]))
            {
                if (Char.IsUpper(charArray[i]))
                {
                    tempChars[i] = Char.ToLower(charArray[i]);
                }
                else if (Char.IsLower(charArray[i]))
                {
                    tempChars[i] = Char.ToUpper(charArray[i]);
                }
            }
            else
            {
                tempChars[i] = charArray[i];
            }
        }
        return new string(tempChars);
    }


    //Reverse the order of a string
    public static string Reverse(this string s)
    {
        char[] tempChars = new char[s.Length];
        char[] charArray = s.ToCharArray();
        int counter = 0;

        for (int i = charArray.Length - 1; i >= 0; i--)
        {            
            tempChars[counter] = charArray[i];
            counter++;
        }
        return new string(tempChars);
    }
}