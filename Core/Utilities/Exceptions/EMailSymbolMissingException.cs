using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Exceptions
{
    public class EMailSymbolMissingException:Exception
    {
        public EMailSymbolMissingException(string massage):base(massage)
        {

        }
    }
}
