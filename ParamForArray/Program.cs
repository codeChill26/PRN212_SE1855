﻿int sum(params int[]arr)
{
    int s = 0;
    foreach(int x in arr)
        s+=x;
    return s;

}
Console.WriteLine(sum());
Console.WriteLine(sum(1,4,9));
Console.WriteLine(sum(1, 3, 4, 53, 4));
