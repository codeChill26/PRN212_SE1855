using System.Text;

void ham1(int n)
{
    n = 8;
    Console.WriteLine($"n trong hàm = {n}");

}
Console.OutputEncoding = Encoding.UTF8;
int n = 5;
Console.WriteLine($"n trước khi vào hàm = {n}");
ham1(n);
Console.WriteLine($"n sau khi vao hàm ={n}");

void ham2(ref int n)
{
    n = 8;
    Console.WriteLine($"n trong hàm = {n}");

}
Console.WriteLine("-------------------------");
n = 5;
Console.WriteLine($"n trước khi vào hàm = {n}");
ham2(ref n);
Console.WriteLine($"n sau khi vao hàm ={n}");
//ref: phải khởi tạo giá tị cho biến trước khi gọi
//int m 
//ham2(ref m) báo lỗi vì m chưa có giá trị
void ham3(out int n)
{
       n = 8;
    Console.WriteLine($"n trong hàm = {n}");
}
