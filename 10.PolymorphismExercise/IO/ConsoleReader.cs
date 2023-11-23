using Ctrl+Shift+HToChangeTheWholeNamespace.IO.Interfaces;
using System;

namespace Ctrl+Shift+HToChangeTheWholeNamespace.IO;

public class ConsoleReader : IReader
{
    public string ReadLine() => Console.ReadLine();
}
