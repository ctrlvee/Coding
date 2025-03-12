using System.Diagnostics.Eventing.Reader;
using Spectre.Console;

namespace CodingLogger.Models;

internal class CodingSession {
    internal int Id {get;set;}
    internal string StartTime {get;set;}
    internal string EndTime {get;set;}

    internal CodingSession(int id, string start, string end) {
        Id = id;
        StartTime = start;
        EndTime = end;
    }

    public void DisplayDetails() {
        Console.WriteLine("Displaying Details");
    }
}