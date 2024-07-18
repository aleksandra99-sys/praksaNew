using System.Net;

namespace Praksa.Exceptions
{
    public class ForbiddenException : BaseException
    {
        public ForbiddenException(string message) : base(message, HttpStatusCode.Forbidden)
        {

        }
    }
}
