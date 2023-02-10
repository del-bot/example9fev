void Polindr(string number)
{
    int j = number.Length-1;
    for ( int i = 0; i < j-i; i++)
    {
        if (number[i] == number[j-i])
        Console.WriteLine("yes, it is polyndrom");
        else Console.WriteLine("no, it is not");
        i++;
    }
}
Console.Write("input number");
string? UserNumber = Console.ReadLine();
if (UserNumber!.Length == 5)
{
    Polindr(UserNumber);
}
else Console.WriteLine("input correct number");
