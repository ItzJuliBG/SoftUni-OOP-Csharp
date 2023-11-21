

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();

IEngine engine = new Engine(reader, writer);

engine.Run();

