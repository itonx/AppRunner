using System.Diagnostics;

string[] arguments = Environment.GetCommandLineArgs();
if(arguments.Length > 1)
{
    if(arguments.Length == 2)
    {
        Process.Start(arguments[1]);
    }else if(arguments.Length == 3)
    {
        Process.Start(arguments[1], arguments[2]);
    }
}