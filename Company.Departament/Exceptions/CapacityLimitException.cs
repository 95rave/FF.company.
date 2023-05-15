using System;


namespace FFBusiness.Exceptions
{
    public class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message)
        {
        }
    }

}  
