using WildFarm.IO.Interfaces;
using System;

namespace WildFarm.IO;

public class ConsoleWriter : IWriter
{
    public void WriteLine(string str) => Console.WriteLine(str);
}

