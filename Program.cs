Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 1 || n < 5)
Console.WriteLine("нет");
else
{
    while ( n > 6 || n < 7)
        Console.Write("да");
}