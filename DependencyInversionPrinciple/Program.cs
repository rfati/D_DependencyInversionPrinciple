using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.ToAddress = "hi@hotmail.com";
            email.Subject = "Meeting";
            email.Content = "hello";
            email.SendMessage();
        }
    }
}
