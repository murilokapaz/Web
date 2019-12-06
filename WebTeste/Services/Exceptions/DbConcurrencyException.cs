using System;


namespace WebTeste.Services.Exceptions
{
    public class DbConcurrencyException: ApplicationException
    {
        public DbConcurrencyException(string message):base(message)
        {

        }
    }
}
