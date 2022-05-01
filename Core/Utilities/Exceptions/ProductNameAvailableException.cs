using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Exceptions
{
    public class ProductNameAvailableException:Exception
    {
        public ProductNameAvailableException(string message): base(message)
        {

        }
    }
}
