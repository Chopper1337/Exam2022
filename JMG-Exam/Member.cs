using System;

namespace JMG_Exam
{
    //Enum for payment schedule
    public enum PaymentSchedule { Annual, Biannual, Monthly }
    internal class Member
    {
        //Properties for a member
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Fee { get; set; }
        public PaymentSchedule PaymentType { get; set; }
        public string MemberType = "Regular";

        //Constructor
        public Member()
        {

        }

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
                return Fee;
            }

            //In case of error
            return 9999;
        }

        //Calculates the renewal date
        internal DateTime RenewalDate()
        {
            DateTime nt = DateTime.Now;
            DateTime jd = JoinDate;

            if (PaymentType == PaymentSchedule.Monthly)
            {
                while (jd < nt)
                {
                    jd = jd.AddMonths(1);
                }

                return jd;
            }
            else if (PaymentType == PaymentSchedule.Biannual)
            {
                while (jd < nt)
                {
                    jd = jd.AddMonths(6);
                }

                return jd;
            }
            else
            {
                while (jd < nt)
                {
                    jd = jd.AddYears(1);
                }

                return jd;
            }
        }

        //Calculates days to renewal
        internal int DaysToRenewal()
        {
            DateTime now = DateTime.Now;
            DateTime renew = RenewalDate();
            int days = 0;

            while(renew <= now)
            {
                renew = renew.AddDays(1);
                days++;
            }

            return days;
        }

        //Override for ToString such that the list of members shows names
        public override string ToString()
        {
            return Name;
        }
    }
}
