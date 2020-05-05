using System;
namespace Aula145ap.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) 
           : base(message)
        {
        }
    }
}
