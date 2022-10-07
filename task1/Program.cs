//кратно ли чесло 7 и 23
Console.WriteLine("ведите число:");
int a = int.Parse(Console.ReadLine());
int b = 7;
int c =23;

if(a % b == 0 &&  a % c == 0)
{
Console.WriteLine("кратно 7 и 23");
}
else
{
    Console.WriteLine("не кратно 7 и 23");
}