using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace Business.Adapters.SmsService
{
    public interface ISmsSender
    {
        MessageResource SendSmsAsync(string number,string message);

    }
}
