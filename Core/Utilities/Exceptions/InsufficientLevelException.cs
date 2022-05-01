using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Exceptions
{
    public class InsufficientLevelException:Exception
    {
        public InsufficientLevelException(string massage):base(massage)
        {

        }
    }
}
