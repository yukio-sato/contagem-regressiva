Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
string frase = "Preparar . . .";
for (int i = 0; i < frase.Length; i++)
{

    Console.Write(frase[i]);
Thread.Sleep(125);
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkRed;
 frase = "Apontar . . .";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
Thread.Sleep(125);
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkYellow;
 frase = $"Fogo!!!\n";
for (int i = 0; i < frase.Length; i++)
{
    if (i < frase.Length-4)
    {
    Console.Write(frase[i]);
Thread.Sleep(125);
    }
    else if (i < frase.Length-3)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(frase[i]);
Thread.Sleep(125);
        }
else if (i < frase.Length-2)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(frase[i]);
Thread.Sleep(125);
    }
    else if (i < frase.Length-1)
        {
            Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"{frase[i]}\n");
Thread.Sleep(125);
    }
}
Console.ResetColor();