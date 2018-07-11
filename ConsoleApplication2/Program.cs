using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Twilio;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string TwilioSID = "";
            const string TwilioTOKEN = "";

            TwilioClient.Init(TwilioSID, TwilioTOKEN);

           var message =  MessageResource.Create(
                to: new PhoneNumber(""),
                from: new PhoneNumber(""),
                body: "");

            Console.WriteLine(message.Sid);
        }
    }
}