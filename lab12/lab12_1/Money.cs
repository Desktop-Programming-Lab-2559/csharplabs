using System;
using System.Collections.Generic;
using System.Text;

namespace lab12_2
{
    class Money
    {
        private double sum;
        public double Sum
        {
            get { return sum; }
            set
            {
                if (value < 0)
                {
                    throw new Exception(" Sum must be positive");
                }
                sum = value;
            }
        }
        private double dollar_course;
        public double Dollar_course
        {
            get { return dollar_course; }
            set
            {
                if (value < 0)
                {
                    throw new Exception(" Sum must be positive");
                }
                dollar_course = value;
            }
        }
        public Money(double sum, double dollar_course)
        {
            Dollar_course = dollar_course;
            Sum = sum / Dollar_course;
        }


        public override string ToString()
        {
            return $"sum = {Sum}$";
        }
        public double Add_Money(double sum2)
        {
            return (Sum + sum2 / Dollar_course);
        }

        public double Withdrawal_Money(double sum2)
        {
            if (Sum < sum2)
            {
                throw new Exception("Sorry, but you have not enought money ");
            }
            else { 
            double res = (Sum - sum2 / Dollar_course);
            
             return res;
            }
        }
        public double Course()
        {
            
            while(Sum != Sum + 100)
            {
                double D = Dollar_course;
                Sum*= D;
                Sum*= Dollar_course;
                Dollar_course += 0.2;
            }
            return Dollar_course;
           
        }
    }
}

    
