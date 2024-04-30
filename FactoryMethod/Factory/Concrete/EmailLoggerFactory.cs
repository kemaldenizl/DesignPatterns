using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Factory.Abstract;
using FactoryMethod.Loggers.Abstract;
using FactoryMethod.Loggers.Concrete;

namespace FactoryMethod.Factory.Concrete
{
    public class EmailLoggerFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new EmailLogger();
        }
    }
}
