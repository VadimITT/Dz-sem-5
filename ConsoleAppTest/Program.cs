int GetArray(int lenght,int minValue,int maxValue)
{
    int[] array= new int[lenght];
    Random  random = new Random ();
    for (int i = 0;i<array.lenght;i++)
    {
        array[i]=random.Next(minValue-1, maxValue);
    }
    return array;
}

int ReadInt()
{
    int ReadInt()
    {
        string s = Console.ReadLine();
        if (int.TryParse(s, out int i))
            return i;
        return -1;

    }
}

string GetArrayAsString(int[] arrat)
{
    string s = string.Empty;
    foreach (var item in array)
    {
        s += $"{item}, ";
    }
    return s;
}