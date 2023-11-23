using Ctrl+Shift+HToChangeTheWholeNamespace.IO.Interfaces;
using System;

namespace Ctrl+Shift+HToChangeTheWholeNamespace.IO;

public class ConsoleWriter : IWriter
{
    public void WriteLine(string str) => Console.WriteLine(str);
}

