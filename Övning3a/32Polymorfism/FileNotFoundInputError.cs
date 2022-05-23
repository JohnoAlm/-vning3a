using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3a
{
    internal class FileNotFoundInputError: UserError
    {
        public override string UEMessage()
        {
            return "You specified a location in which a file could not be found. This fired an error!";
        }
    }
}
