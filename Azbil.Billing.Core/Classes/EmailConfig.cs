using Azbil.Billing.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Core.Classes
{
    public class EmailConfig : IEmailConfig
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Host { get; set; }

        public string Port { get; set; }

        public string EnableSsl { get; set; }
    }
}
