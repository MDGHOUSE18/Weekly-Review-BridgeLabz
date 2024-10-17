using System;
using System.Collections.Generic;
using System.Text;

namespace Week4
{
    public class PrimeNumbers
    {
        public bool PrimeOrNot(int num)
        {
            if (num == 0 || num==1 || num<0) return false;
            for(int i = 2; i < Math.Sqrt(num); i++)
            {
                if(num%i==0) return false;
            }
            return true;
        }
    }
}
