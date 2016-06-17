using System.Threading.Tasks;

namespace Trivia.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
