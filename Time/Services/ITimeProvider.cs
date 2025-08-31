// Services/ITimeProvider.cs
namespace Time.Services;

public interface ITimeProvider
{
    DateTime GetCurrentTime();
}