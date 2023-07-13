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

    //Search a string to see how many of a certain char are in it
    public static int LetterCount(string stringToSearch, char letterToFind)
    {
        // Convert both stringToSearch and letterToFind to lowercase or uppercase
        stringToSearch = stringToSearch.ToLower();
        letterToFind = char.ToLower(letterToFind);

        int count = 0;
        for (int i = 0; i < stringToSearch.Length; i++)
        {
            // Compare the char case-insensitively
            if (char.ToLower(stringToSearch[i]) == letterToFind)
            {
                count++;
            }
        }
        return count;
    }

}