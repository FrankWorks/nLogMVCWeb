using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Common;

namespace Infrastructure.VO
{
    public class ProcessVO : ApplicationBase
    {
        public ProcessVO() :base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            Log.Trace("Trace----........");
        }   
    }
}
