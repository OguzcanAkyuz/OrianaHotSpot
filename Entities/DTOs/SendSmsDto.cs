using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SendSmsDto
    {
        public string MobileNumber { get; set; }
        public string Body { get; set; }
    }
}
