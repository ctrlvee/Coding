using System.Diagnostics.Eventing.Reader;

namespace CodingLogger.Models;

internal abstract class CodingSession {
    public int Id {get;set;}
    public string StartTime {get;set;}
    public string EndTime {get;set;}

    protected CodingSession(int id, string start, string end) {
        Id = id;
        StartTime = start;
        EndTime = end;
    }

    public abstract void DisplayLogs();
}