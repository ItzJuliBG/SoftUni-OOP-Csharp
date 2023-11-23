using Ctrl+Shift+HToChangeTheWholeNamespace.IO.Interfaces;
using System.IO;

namespace Ctrl+Shift+HToChangeTheWholeNamespace.IO;

public class FileWriter : IWriter
{
    public void WriteLine(string str)
    {
        using StreamWriter writer = new("D:\\test.txt", true);

        writer.WriteLine(str);
    }
}
