using System;

namespace Entities.Exceptions;

class DomainException : ApplicationException
{
    public DomainException(string message)
        : base(message)
    {
        
    }
}