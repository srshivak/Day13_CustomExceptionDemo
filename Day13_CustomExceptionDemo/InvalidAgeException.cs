using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Day13_CustomExceptionDemo
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) 
        {

        }
    }
}
