using System;
using src.IOC.Service;

namespace src.IOC.Exception
{
    public class DuplicateServiceException: System.Exception
    {
        public DuplicateServiceException(Type serviceType, IService existing, IService redundant)
            :base($"Tried to register {redundant} as {serviceType.Name}, when {existing} was already registered as this service.")
        { }
    }
}