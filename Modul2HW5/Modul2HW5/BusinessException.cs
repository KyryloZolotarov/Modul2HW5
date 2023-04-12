using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW5
{
    internal class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}
