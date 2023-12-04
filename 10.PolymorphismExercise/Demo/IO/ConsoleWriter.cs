using Demo.IO.Interfaces;
using System;

namespace Demo.IO;

public class ConsoleWriter : IWriter
{
    public void WriteLine(string str) => Console.WriteLine(str);
}

