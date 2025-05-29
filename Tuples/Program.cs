(int, double) SumAndAverage(params int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
        double avg=sum/ arr.Length;
        return (sum, avg);
    }
}
int[] arr = {1, 2, 3, 4, 5};
(int s, double v) = SumAndAverage(arr);
Console.WriteLine($"Tổng là {s} và trung bình là {v}");
