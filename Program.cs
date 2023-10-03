Console.WriteLine("Años bisiestos desde 1900:");
for (int i = 1900; i <= 2023; i++)
{
    if (i % 4 == 0 && i % 100 != 0) //bisiesto multiplo de 4
    {
        Console.WriteLine(i);
    }
    if (i % 400 == 0) // bisiesto multiplo de 400
    {
        Console.WriteLine(i);
    }
}