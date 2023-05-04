using System.Diagnostics;
using ClockInMirrorLib;

Console.WriteLine("");
Console.WriteLine("Clock in Mirror - solution of codewars-kata by ahagert (2023)");

string? mirrorTime;
ConsoleKeyInfo tryAgain;

do 
{
    Console.WriteLine("");
    do 
    {
        Console.Write("time you see in the mirror (HH:mm): ");
        mirrorTime = Console.ReadLine();

    } while (!TimeFormatValidator.ValidateTimeFormat(mirrorTime));

    var realTime = MirrorTimeConverter.WhatIsTheTime(mirrorTime);
    Console.WriteLine("");
    Console.WriteLine("real time: " + realTime);

    Console.WriteLine("");
    Console.Write("once again? (y/n)");
    do 
    {
        tryAgain = Console.ReadKey();
    } while (!(tryAgain.Key == ConsoleKey.Y || tryAgain.Key == ConsoleKey.N));
    Console.WriteLine("");
} while (tryAgain.Key == ConsoleKey.Y);

Console.WriteLine("bye bye");
Console.WriteLine("");