using FactoryMethod.Factory.Concrete;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EmailLoggerFactory());
            customerManager.CreateCustomer();
        }
    }
}
