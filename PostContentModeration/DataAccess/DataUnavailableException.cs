using System;
using System.Runtime.Serialization;

namespace DataAccess
{
    public class DataUnavailableException : Exception
    {
        public DataUnavailableException() : base("Can't access data source")
        {
        }
    }
}