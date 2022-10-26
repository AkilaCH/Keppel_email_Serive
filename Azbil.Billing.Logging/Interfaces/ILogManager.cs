using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Logging.Interfaces
{
    public interface ILogManager
    {
        void Trace(string trace);

        void Debug(string debug);

        void Info(string info);

        void Warning(string warning);

        void Error(string error);

        void Fatal(string fatal);

        void Trace(Exception exception, string trace);

        void Debug(Exception exception, string debug);

        void Info(Exception exception, string info);

        void Warning(Exception exception, string warning);

        void Error(Exception exception, string error);

        void Fatal(Exception exception, string fatal);

        void Trace(Exception exception);

        void Debug(Exception exception);

        void Info(Exception exception);

        void Warning(Exception exception);

        void Error(Exception exception);

        void Fatal(Exception exception);
    }
}
