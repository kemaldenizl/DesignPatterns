using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Factory.Abstract;
using FactoryMethod.Loggers.Abstract;

namespace FactoryMethod
{
    public class CustomerManager
    {
        private readonly ILoggerFactory _loggerFactory;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void CreateCustomer()
        {
            Console.WriteLine("Customer created!");
            ILogger logger = _loggerFactory.Create();
            logger.Log();
        }
    }
}
