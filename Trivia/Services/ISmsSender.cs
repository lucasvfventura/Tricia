using System.Threading.Tasks;

namespace Trivia.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
