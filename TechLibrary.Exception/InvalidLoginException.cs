using System.Net;

namespace TechLibrary.Exception;

public class InvalidLoginException : TechLibraryException
{
    public InvalidLoginException() : base("Invalid email and/or password!") { }
    public override List<string> GetErrorMessages() => [Message];
    public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
}