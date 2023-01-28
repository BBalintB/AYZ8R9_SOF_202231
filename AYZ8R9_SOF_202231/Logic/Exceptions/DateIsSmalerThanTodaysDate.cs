namespace AYZ8R9_SOF_202231.Logic.Exceptions
{
    public class DateIsSmalerThanTodaysDate : Exception
    {
        public DateIsSmalerThanTodaysDate(string? message) : base(message)
        {
        }
    }
}
