Console.WriteLine("WRITE ME A NUMBER NILLY WILLY");
string input = Console.ReadLine();
while (!int.TryParse(input, out int value))
{
    Console.WriteLine("NO A NUMBER YOU SILLY DRAGOON");
    input = Console.ReadLine();
}
Console.WriteLine($"WHOA {input} THAT IS INDEED A NUMBER");
Console.ReadLine();