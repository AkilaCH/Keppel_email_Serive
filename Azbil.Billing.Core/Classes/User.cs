using Azbil.Billing.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Core.Classes
{
    public class User : IUser
    {
        public int UserId { get; set; }

        public string UserEmail { get; set; }
    }
}
