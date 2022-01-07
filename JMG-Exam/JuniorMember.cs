using System;

namespace JMG_Exam
{
    internal class JuniorMember : Member
    {
        public string MemberType = "Junior Member";
        public decimal Fee { get; set; }

        //Returns the members details as a string for the member details text block
        public string MemberDetails()
        {
            string md = $"{Name}\nJoin date: {JoinDate}\nBasic fee: €{Fee}\nPayment schedule: {PaymentType.ToString()} - €{CalculateFees()}\nRenewal date: {RenewalDate().ToShortDateString()}\nDays to renewal: {DaysToRenewal()}\nMember type: {MemberType}";
            return md;
        }
        //Calculates members fees based upon their payment type
        internal decimal CalculateFees()
        {
            if (PaymentType == PaymentSchedule.Monthly)
            {
                return Math.Round((Fee / 12), 2);
            }
            else if (PaymentType == PaymentSchedule.Biannual)
            {
                return Math.Round((Fee / 2), 2);
            }
            else
            {
                double dFee = Double.Parse(Fee.ToString());
                double x = dFee * 0.5;
                x = Math.Round(x, 2);
                return Convert.ToDecimal(x);
            }

            //In case of error
            return 9999;
        }
    }
}
