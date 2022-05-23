using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    internal class NumberToBigInputError: UserError
    {
        public override string UEMessage()
        {
            return "The number you specified is too big to fit in an Int32. This fired an error!";
        }
    }
}
