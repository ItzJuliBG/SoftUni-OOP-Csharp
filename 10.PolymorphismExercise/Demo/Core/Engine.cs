using Demo.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Demo.Core;

public class Engine : IEngine
{
    private readonly IReader reader;
    private readonly IWriter writer;

    public Engine(IReader reader, IWriter writer)
    {
        this.reader = reader;
        this.writer = writer;
    }

    public void Run()
    {
        //Main code here
    }
}

