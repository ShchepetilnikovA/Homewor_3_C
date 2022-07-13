bool Palindrom(int n)
{
    if(n / 10000 == n % 10) 
    {
        n = (n / 10) % 1000;
        
        if(n / 100 == n % 10)
            return true;
        else return false;
    }
    else return false;  
}

Console.WriteLine("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Is it palindrom? " + Palindrom(number));


