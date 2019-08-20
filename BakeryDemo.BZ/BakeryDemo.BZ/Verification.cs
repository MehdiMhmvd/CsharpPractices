using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryDemo.BZ
{
    public class Verification
    {
        public Verification(Customer customer )
        {
            //var customer = new Customer();
            this.customer = customer;
            this.Phone = customer.PhoneNumber;
        }

        private int VerificationCode;
        private int UserCode;
        private Customer customer;
        private DateTime StartDateTime;
        private DateTime EndDateTime;


        private long Phone { get; set; }


        private int GeneratingVerificationCode()
        {
            var RandomCode = new Random();
            VerificationCode = RandomCode.Next(9999, 999999);
            return VerificationCode;
        }
        private void SendingVerificationCodeByPhone()
        {
            Console.WriteLine("Your verification Code is:");
            Console.WriteLine(GeneratingVerificationCode());
            Console.WriteLine(customer.WrongEnteredCode);
            Console.WriteLine("----------------------");

            
        }
        private void GettingUsercode()
        {
            Console.WriteLine("Please Enter verification Code:");
             UserCode = Int32.Parse(Console.ReadLine());
            
        }
        private void verificationProcess()
        {
            GeneratingVerificationCode();
            SendingVerificationCodeByPhone();
            GettingUsercode();

        }
        private bool IsRestricted()
        {
           EndDateTime = DateTime.Now;
           TimeSpan Difference = EndDateTime - StartDateTime;
            if (Difference.Minutes > 10)
            {
                return false;
            }
            return true;

        }

        public void VerifyCustomerByPhone()
        {
                
                if (customer.WrongEnteredCode < 3 && !IsRestricted())
                {
                    verificationProcess();
                    if (VerificationCode == UserCode)
                    {
                        customer.IsVerified = true;
                        Console.WriteLine("Accepted");
                         
                    }
                    else
                    {
                        Console.WriteLine("Worng Code");
                        customer.WrongEnteredCode++;

                    }
                }
                else
                {
                Console.WriteLine("You have Entered 3 wrong Activation Code, PLz try 10 minutes later ");
                StartDateTime = DateTime.Now;
                }




        }


    }
}
