double Distance (int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ),2);
    return distAB;
}
Console.WriteLine("input x coordinat of a ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y coordinat of a ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z coordinat of a ");
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input x coordinat of B ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y coordinat of b ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z coordinat of b ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = Distance (xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine($"distance between a and b is {distanceAB}");