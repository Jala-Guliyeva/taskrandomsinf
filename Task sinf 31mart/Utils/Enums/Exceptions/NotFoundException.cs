using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Enums.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
