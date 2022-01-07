using System;

namespace JMG_Exam
{
    internal class SeniorMember : Member
    {
        public string MemberType = "Senior Member";
        public decimal Fee { get; set; }

        //Calculates members fees based upon their payment type
        internal decimal CalculateFees()
        {
            if (PaymentType == PaymentSchedule.Monthly)
            {
                return Fee / 12;
            }
            else if (PaymentType == PaymentSchedule.Biannual)
            {
                return Fee / 2;
            }
            else
            {
                double dFee = Double.Parse(Fee.ToString());
                return Convert.ToDecimal(dFee * 0.75);
            }

            //In case of error
            return 9999;
        }
    }
}
