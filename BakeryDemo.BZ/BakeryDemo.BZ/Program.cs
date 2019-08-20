using System;

namespace BakeryDemo.BZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer()
            {
                CustomerId = 1,
                IMEI = 222222222222222,
                PhoneNumber = 09145675251,
            };
            var v = new Verification(customer1);

            v.VerifyCustomerByPhone();
            v.VerifyCustomerByPhone();
            v.VerifyCustomerByPhone();
            v.VerifyCustomerByPhone();



            Console.ReadLine();
            
        }
    }
}
