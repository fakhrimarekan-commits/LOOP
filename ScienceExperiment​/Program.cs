
int Suhu;

do
{
    Console.Write("Input your temperature (between -50 until 150): ");
    Suhu = int.Parse(Console.ReadLine()!);

    if (Suhu < -50 || Suhu > 150)
    {
        Console.WriteLine("Invalid input. Temperature must be between -50 and 150.");
    }

} while (Suhu < -50 || Suhu > 150);

Console.WriteLine($"Temperature recorded: {Suhu}°C");

if (Suhu < 0)
{
    Console.WriteLine("Category: Freezing");
}
else if (Suhu <= 30)
{
    Console.WriteLine("Category: Normal");
}
else if (Suhu <= 100)
{
    Console.WriteLine("Category: Hot");
}
else
{
    Console.WriteLine("Category: Extremely Hot");
}