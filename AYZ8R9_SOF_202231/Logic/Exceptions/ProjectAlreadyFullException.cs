namespace AYZ8R9_SOF_202231.Logic.Exceptions
{
    public class ProjectAlreadyFullException : Exception
    {
        public ProjectAlreadyFullException(string? message) : base(message)
        {
        }
    }
}
