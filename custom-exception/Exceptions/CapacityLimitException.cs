namespace custom_exception.Exceptions
{
    internal class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message) { }

    }
}
