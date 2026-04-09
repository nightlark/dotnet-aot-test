using System.Runtime.InteropServices;

Console.WriteLine("Hello, NativeAOT!");
Console.WriteLine($"Runtime: .NET {Environment.Version}");
Console.WriteLine($"OS: {RuntimeInformation.OSDescription}");
Console.WriteLine($"Architecture: {RuntimeInformation.ProcessArchitecture}");
