using System;

Console.WriteLine(FindUniqueNumber(new []{1,1,1,2}));
Console.WriteLine(FindUniqueNumber(new []{2,3,3}));
Console.WriteLine(FindUniqueNumber(new []{3,4,3}));
Console.WriteLine("\n2\n2\n4");
int FindUniqueNumber(int[] arr)
{
    if (arr.Length < 3)
        throw new Exception("Array must have at least 3 elements");


    for (int i = 0; i < arr.Length-2; i++)
    {
        //pokud [i] == [i+1]
        //ok, pokud však [i] != [i+1]
        //i++ -> [i] == [i+1] => Levý prvek unique : pravý prvek unique

        if (arr[i] != arr[i + 1])
        {
            int susNumber = arr[i];
            if (susNumber == arr[i + 2])
            {
                return arr[i + 1];
            }

            return susNumber;
        }
    }

    return arr[^1];
}
