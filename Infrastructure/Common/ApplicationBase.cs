using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Web;
namespace Infrastructure.Common
{
    public class ApplicationBase
    {
        protected Logger Log { get; private set; }
        protected ApplicationBase(Type declaringType)
        {
            Log = LogManager.GetLogger(declaringType.FullName);
        }
    }
}
