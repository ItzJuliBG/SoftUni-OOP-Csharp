using Raiding.Core;
using Raiding.IO;
using Raiding.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
Engine engine = new Engine(reader, writer);

engine.Run();

