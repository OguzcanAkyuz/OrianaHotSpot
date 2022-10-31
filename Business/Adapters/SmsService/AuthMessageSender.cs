
using Entities.Concrete;
using Microsoft.Extensions.Options;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Business.Adapters.SmsService
{
    // This class is used by the application to send Email and SMS
    // when you turn on two-factor authentication in ASP.NET Identity.
    // For more details see this link https://go.microsoft.com/fwlink/?LinkID=532713
    public class AuthMessageSender : ISmsSender
    {
        public AuthMessageSender(IOptions<SmsVerification> optionsAccessor)
        {
            _options = optionsAccessor.Value;
        }

        public SmsVerification _options { get; }  // set only via Secret Manager



        public MessageResource SendSmsAsync(string number, string message)
        {



            TwilioClient.Init(_options.SMSAccountIdentification, _options.SMSAccountPassword);

            var result = MessageResource.Create(
               to: new PhoneNumber(number),
               from: new Twilio.Types.PhoneNumber(_options.SMSAccountFrom),
               body: message);
            return result;
        }
    }
}