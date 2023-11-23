using Ctrl+Shift+HToChangeTheWholeNamespace.Core;
using Ctrl+Shift+HToChangeTheWholeNamespace.IO;
using Ctrl+Shift+HToChangeTheWholeNamespace.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
Engine engine = new Engine(reader, writer);

engine.Run();

