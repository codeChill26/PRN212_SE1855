using System.Text;

void swap(ref int a, ref int b)
{
    int temp = a; a = b; b = temp;
}
void sort_arr(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = i + 1; j < a.Length; j++)
        {
            if (a[i] > a[j])
            {
                swap(ref a[i], ref a[j]);
            }
        }
    }
}
void create_array(int[] a)
{
    Random rd = new Random();
    for (int i = 0; i < a.Length; i++)
    {
        a[i]= rd.Next(100);
    }
} 
void print_array(int[] a)
{
    foreach (int x in a)
    {
        Console.Write($"{x}\t");
    }
}
int[]arr = new int[10];
create_array(arr);
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Mảng trước khi sắp xếp");
print_array(arr);
Console.WriteLine("sAU SAP XEO" );
sortDoWhile (arr);
print_array(arr);

void sortWhile(int[] a)
{
    int i = 0;
    while (i<a.Length)
    {
        int j = i + 1;
        while (j < a.Length)
        {
            if (a[i] > a[j])
            {
                swap(ref a[i], ref a[j]);
            }
            j++;
        }
        i++;

    }
}
void sortDoWhile(int[] a)
{
    int i = 0;
    do
    {
        int j = i + 1;
        do
        {
            if (a[i] > a[j])
            {
                swap(ref a[i], ref a[j]);
            }
            j++;

        } while (j < a.Length);
        i++;
    } while ( i< a.Length-1);
}