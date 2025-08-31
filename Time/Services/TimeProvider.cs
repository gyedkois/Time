// Services/TimeProvider.cs
using Time.Services;

namespace Time.Services;

public class TimeProvider : ITimeProvider
{
    public DateTime GetCurrentTime()
    {
        return DateTime.Now;
    }
}