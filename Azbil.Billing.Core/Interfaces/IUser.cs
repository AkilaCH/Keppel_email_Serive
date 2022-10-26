using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Core.Interfaces
{
    public interface IUser
    {
        int UserId { get; set; }

        string UserEmail { get; set; }
    }
}
