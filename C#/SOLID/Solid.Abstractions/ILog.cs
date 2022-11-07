namespace Solid.Abstractions;
public interface ILog
{
    void WriteLog(string? msg, Exception? ex = null);
}
