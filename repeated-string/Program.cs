long FirstLetterCount(string text, long n)
{
    int stringLength = text.Length;
    
    long count = 0;
    for (int i = 0; i < stringLength; i++)
    {
        if (text[i] == 'a')
        {
            count++;
        }
    }
    long fullStringCount =(long) n / stringLength;
    count *= fullStringCount;

    long remainder = n % stringLength;
    for (int i = 0; i < remainder; i++)
    {
        if (text[i] == 'a')
        {
            count++;
        }
    }
    return count;
}

long result = FirstLetterCount("a", 1000000000000);
Console.WriteLine(result);

