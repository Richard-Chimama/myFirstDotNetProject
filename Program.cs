using CommandLine;
using myFirstDotNetProject;


Parser.Default.ParseArguments<Options>(args).WithParsed<Options>(AsciiArt.Write).WithNotParsed(_ => WriteLine("Usage: HelloDotnet <text> --font Big"));

