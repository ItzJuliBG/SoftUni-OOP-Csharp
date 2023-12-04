using Demo.IO.Interfaces;
using System;

namespace Demo.IO;

public class ConsoleReader : IReader
{
    public string ReadLine() => Console.ReadLine();
}
