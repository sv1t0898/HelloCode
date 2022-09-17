int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] namearray = {12,32,756,75,34,5444,22,32,93};

namearray[0] = 12;
Console.WriteLine(namearray[0]);

int max = Max(
    Max(namearray[0], namearray[1], namearray[2]),
    Max(namearray[3], namearray[4], namearray[5]),
    Max(namearray[6], namearray[7], namearray[8])
);




//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);