using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {
        public NotFoundExceptions(string message) : base(message)
        {
        }
    }
}
