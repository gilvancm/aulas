﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula144ap.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
       
        }
    }
}
