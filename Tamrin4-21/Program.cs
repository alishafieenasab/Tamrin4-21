Console.WriteLine("Hello, World!");

//Console.WriteLine(xyzMiddle("axyzbb"));

bool xyzMiddle(string aString)
{
    bool flag = false;
    for(int i = 0; i < aString.Length; i++)
    {
        if(aString[i] == 'y')
        {
            if(aString[i + 1] == 'z' && aString[i - 1] == 'x')
            {
                if((i - 1) == (aString.Length - (i + 1)) || (i - 1) - (aString.Length - (i + 1)) == 1 || ((aString.Length - 1) - (i + 1)) - (i - 1) == 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
        }
    }
    return flag;
}

//---------------------Part2-----------------

int[] arr = { 5, 2, 6, 7, 8 };

//Console.WriteLine(tripleUp(arr));

bool tripleUp(int[] aArray)
{
    int j = 0;
    bool flag = false;
    for(int i = 1; i < aArray.Length; i++)
    {
        if((aArray[i - 1] + 1) == aArray[i])
        {
            j++;
        }
    }
    if(j == 2)
        flag = true;
    return flag;
}

//-------------------Part3-------------------

int[] arr2 = { 1, 2, 3 };

Console.WriteLine(isEverywhere(arr2, 2));

bool isEverywhere(int[] aArray, int aInt)
{
    int j = 0;
    int z = (aArray.Length / 2) + 1;
    bool flag = false;
    for (int i = 0; i < aArray.Length; i += 2)
    {
        if ((aArray.Length - i) == 1)
        {
            if (aArray[i] == aInt)
            {
                j++;
            }
        }
        else
        {
            if (aArray[i] == aInt || aArray[i + 1] == aInt)
            {
                j++;
            }
        }
    }
    if(z == j)
    {
        flag = true;
    }
    return flag;
}