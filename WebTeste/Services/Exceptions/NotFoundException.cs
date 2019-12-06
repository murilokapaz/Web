using System;

namespace WebTeste.Services.Exceptions
{
    public class NotFoundException: ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
