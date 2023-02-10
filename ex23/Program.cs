void Quards(int uN)
{
    int current = 1;
    while (current <= uN)
    {
        double res = Math.Pow(current, 3);
        Console.WriteLine($"{res}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}
Console.Write("input number");
int user_number = Convert.ToInt32(Console.ReadLine());

if(user_number >= 1)
{
    Console.Write($"{user_number} -> ");
    Quards(user_number);
}
else Console.WriteLine("impossible value");
