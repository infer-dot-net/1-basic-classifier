# 0: Base Repo

If you are use to scripting languages like Python, setting up a compiled language project like C# on Linux, Windows or MacOS can be daunting to say the least. Further, getting the dotNet framework to work and then Microsoft's inferDotNot package on top of that creates more barriers to get going coding up the awesome probabilistic models that you can build with the inferDotNet package. 

This repo is used as the base repo for projects that have models that are called from python notebooks. You can fork this repo to have a boiler plate setup for a inferDotNet model.

## Installing C# and inferDotNet

Luckily VS Code is also supported (funded) by Microsoft, so they've got some incentive to make it as easy as possible to set up C# and VS Code on Linux, Windows and Mac.

You can install .Net <a href="https://dotnet.microsoft.com/download">here</a>.

Once installed you should be able to run the `dotnet` command in the CLI. If not, refer to the .Net documentation to get to this point.

Once you can run the `dotnet` command, we can easily create a new CLI .Net project with the following:

```bash
dotnet new console
```

This will create all the required C# files required to be able to compile our programs which resides in the `Program.vs` file. We've run `dotnet new console` in <a href="./models/model-1">models/model-1</a> which populates <a href="./models/model-1/Program.cs">models/model-1/Program.cs</a> with:


```csharp
using System;

namespace model_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

Now you should be able to run

```bash
dotnet run
```

in <a href="./models/model-1">models/model-1</a> to get the output:

```log
Hello World!
```

