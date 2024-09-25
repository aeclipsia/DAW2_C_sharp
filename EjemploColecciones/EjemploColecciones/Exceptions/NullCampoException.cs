using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Exceptions
{
    public class NullCampoException : Exception
    {
        public NullCampoException(string? message) : base(message)
        {
        }
    }
}
