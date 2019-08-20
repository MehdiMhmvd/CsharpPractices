using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryDemo.BZ
{
    public class Customer
    {
        public Customer()
        {
            this.wrongEnteredCode = 0;
        }
        public int CustomerId { get; set; }

        private long imEi;

        public long IMEI
        {
            get { return imEi; }
            set { imEi = value; }
        }
        private long phoneNumber;

        public long PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        private bool isVerfied;

        public bool IsVerified
        {
            get { return isVerfied; }
            set { isVerfied = value; }
        }

        private int wrongEnteredCode;

        public int WrongEnteredCode
        {
            get { return wrongEnteredCode; }
            set { wrongEnteredCode = value; }
        }


    }
}
