using AspectOriented.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspectOriented.Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success,string messages) : this(success)
        {          
            Messages = messages;
        }
        public Result(bool success)
        {
            Success = success;
        }


        public bool Success { get; }

        public string Messages { get; }

       
    }
}
