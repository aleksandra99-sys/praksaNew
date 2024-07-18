using System.Net;

namespace Praksa.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string message) : base(message, HttpStatusCode.NotFound)
        {

        }
    }
}
