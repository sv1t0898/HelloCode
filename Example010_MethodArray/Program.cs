int[] namearray = {73, 34, 4, 38, 23, 76, 2, 45, 23};

int n = namearray.Length;
int find = 23;

int index = 0;

while (index < n)
{
    if(namearray[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}