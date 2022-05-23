using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    internal class DivideByZeroInputError : UserError
    {
        public override string UEMessage()
        {
            return "You attempted to divide by zero. This fired an error!";
        }
    }
}
