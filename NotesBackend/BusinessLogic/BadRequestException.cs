﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {

        }
    }
}