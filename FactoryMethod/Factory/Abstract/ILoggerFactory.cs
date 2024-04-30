using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Loggers.Abstract;

namespace FactoryMethod.Factory.Abstract
{
    public interface ILoggerFactory
    {
        ILogger Create();
    }
}
