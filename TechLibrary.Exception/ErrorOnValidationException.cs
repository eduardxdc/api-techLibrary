using System.Net;

namespace TechLibrary.Exception;

public class ErrorOnValidationException(List<string> errorMessages) : TechLibraryException(string.Empty)
{
    public override List<string> GetErrorMessages() => errorMessages;

    public override HttpStatusCode GetStatusCode() => HttpStatusCode.BadRequest;
}