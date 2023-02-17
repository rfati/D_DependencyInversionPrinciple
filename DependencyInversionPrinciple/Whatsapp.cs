using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Whatsapp : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public char Emoji { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Message Sending....");
        }
    }
}
