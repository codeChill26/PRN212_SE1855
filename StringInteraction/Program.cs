using System.Text;

String ho = "Huỳnh";
String tenlot = "Kim";
String ten = "Phucs";
String fullname = ho + " " + tenlot + " " + ten;
Console.WriteLine(fullname); // Huỳnh Kim Phucs
StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
Console.WriteLine(sb.ToString()); // Huỳnh Kim Phucs