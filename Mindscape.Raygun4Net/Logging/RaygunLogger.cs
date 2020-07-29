namespace Mindscape.Raygun4Net.Logging
{
  public class RaygunLogger : IRaygunLogger
  {
    public RaygunLogLevel LogLevel { get; set; }
    
    public void Error(string message)
    {
      Log(RaygunLogLevel.Error, message);
    }

    public void Warning(string message)
    {
      Log(RaygunLogLevel.Warning, message);
    }

    public void Info(string message)
    {
      Log(RaygunLogLevel.Info, message);
    }

    public void Debug(string message)
    {
      Log(RaygunLogLevel.Debug, message);
    }

    public void Verbose(string message)
    {
      Log(RaygunLogLevel.Verbose, message);
    }

    private void Log(RaygunLogLevel level, string message)
    {
      if (LogLevel == RaygunLogLevel.None)
      {
        return;
      }
      
      if (level <= LogLevel)
      {
        System.Diagnostics.Trace.WriteLine(message);
      }
    }
  }
}