﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AspectOriented.Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string messages) : base(data, true, messages)
        {
        }
        public SuccessDataResult(T data) : base(data, true)
        { 
        
        }
    }
}
