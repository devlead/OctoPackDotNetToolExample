// Install modules
#module nuget:?package=Cake.DotNetTool.Module&version=0.4.0

// Install .NET Core Global tools.
#tool "dotnet:https://api.nuget.org/v3/index.json?package=Octopus.DotNet.Cli&version=7.4.1"

OctoPack("MyPackage",
     new OctopusPackSettings {
                    Version = "1.0.0",
                    BasePath = "./bin",
                    OutFolder = "./out",
                    Overwrite = true,
                    ToolPath = Context.Tools.Resolve("dotnet-octo")
                                ?? Context.Tools.Resolve("dotnet-octo.exe")
});

