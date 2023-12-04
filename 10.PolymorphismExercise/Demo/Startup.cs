using Demo.Core;
using Demo.IO;
using Demo.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
Engine engine = new Engine(reader, writer);

engine.Run();

