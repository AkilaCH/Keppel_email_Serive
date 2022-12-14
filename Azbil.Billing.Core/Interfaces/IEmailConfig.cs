using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Core.Interfaces
{
    public interface IEmailConfig
    {
        string Username { get; set; }
        
        string Password { get; set; }
        
        string Host { get; set; }
        
        string Port { get; set; }
        
        string EnableSsl { get; set; }
    }
}
