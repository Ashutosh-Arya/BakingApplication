using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApplication
{
    internal class InvalidAccountNoException:Exception
    {
        public InvalidAccountNoException(string message):base(message)
        {
            
        }
    }
}
