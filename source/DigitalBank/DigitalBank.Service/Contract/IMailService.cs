using DigitalBank.Domain;
using System.Threading.Tasks;

namespace DigitalBank.Service.Contract
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
