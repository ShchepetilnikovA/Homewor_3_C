void Cube(int number)
{
    for(int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Console.WriteLine("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);