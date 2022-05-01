using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Exceptions
{
    public class ExsistItemInvantoryException:Exception
    {
        public ExsistItemInvantoryException(string massage):base(massage)
        {

        }
    }
}
