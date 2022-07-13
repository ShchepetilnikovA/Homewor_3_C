double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return result;
}

Console.WriteLine("input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Distance beetwen point: " + Distance(x1, y1, z1, x2, y2, z2));