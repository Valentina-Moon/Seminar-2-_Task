// проверка на полидром пятизначного числа
Console.WriteLine("Введите пятизначное число:");
int n = int.Parse(Console.ReadLine() ?? "0");

int x5 = n%10;
int x4 = n /10%10;
int x2 = n /1000%10;
int x1 = n / 10000;
if ((x5 == x1) && (x4 == x2))
{
    Console.WriteLine(n + "полидром ");

}
else
{
     Console.WriteLine(n + " не является полидром ");
}