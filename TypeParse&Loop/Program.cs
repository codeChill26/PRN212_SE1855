/*Đề:
 * Nhập vào 1 số >=0, nếu nhập sai quy tắc 
 * thì yêu cầu nhập lại khi nào đúng mới udngwf
 * nếu nhập đúng thì tính giai thừa cửa số này
 */
int n = -1;
while (n<0)
{
    String input = Console.ReadLine();
    if (int.TryParse(input, out n) == true)
    {//khi vao đây thì n là số do có tryparse(ép kiểu thành công thì true) 
        if (n >= 0) break;

    }
}
int gt = 1;
for (int i = 1; i <= n; i++)
{
    gt *= i;
}
Console.WriteLine($"Giai thừa của {n} là {gt}");

