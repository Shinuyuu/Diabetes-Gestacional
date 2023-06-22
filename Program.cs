int mg;

﻿void Shin(string frase, int fun)
{
    if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    else if (fun == 03)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else if (fun == 04)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
    }
     else if (fun == 05)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
     else if (fun == 06)
    {
        Console.ForegroundColor = ConsoleColor.Black;
    }
for (int i = 00; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(45);
}
}

Console.Clear();
Shin("Glicemia (em mg/dL): ",05);
Console.ForegroundColor = ConsoleColor.White;
mg = int.Parse(Console.ReadLine()!);
if (mg < 92)
{
Shin("\n\nReavalie cerca de 24 até 28 semanas com TTOG 75g de glicose",03);
}
else if (mg >= 92 && mg < 126)
{

Shin("\n\nCompatível com Diabetes Gestacional",01);
}
else if (mg >= 126)
{
Shin("\n\nDiabetes Mellitus na Gravidez",00);
}
Console.ResetColor();
Thread.Sleep(1550);
Console.Clear();
