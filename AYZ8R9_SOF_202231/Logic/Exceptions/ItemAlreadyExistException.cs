namespace AYZ8R9_SOF_202231.Logic.Exceptions
{
    public class ItemAlreadyExistException : Exception
    {
        public ItemAlreadyExistException(string? message) : base(message)
        {
        }
    }
}
