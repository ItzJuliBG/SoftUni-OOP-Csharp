using WildFarm.Core;
using WildFarm.IO;
using WildFarm.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
Engine engine = new Engine(reader, writer);

engine.Run();

