// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("значение x:");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("значение у:");
int y = int.Parse(Console.ReadLine() ?? "0"); 

if (x>0 && y>0)
{
    Console.WriteLine("1 черверть");

}
else if (x<0 && y>0)
{
    Console.WriteLine("2 четверть");

}
else if (x<0 && y<0)
{
    Console.WriteLine("3 четверть");
}
else 
{
    Console.WriteLine("4 четверть");
}