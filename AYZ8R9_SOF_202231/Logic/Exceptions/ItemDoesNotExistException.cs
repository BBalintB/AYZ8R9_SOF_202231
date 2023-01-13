namespace AYZ8R9_SOF_202231.Logic.Exceptions
{
    public class ItemDoesNotExistException : Exception
    {
        public ItemDoesNotExistException(string? message) : base(message)
        {
        }
    }
}
