using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMG_Exam
{
    //Enum for payment schedule
    public enum PaymentSchedule { Annual, Biannual, Monthly}
    internal class Member
    {
        //Properties for a member
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Fee { get; set; }
        public PaymentSchedule PaymentType { get; set; }
        public string MemberType = "Regular";

        public Member()
        {

        }

        //Constructor
        public Member(string Name, DateTime JoinDate, decimal Fee, PaymentSchedule paymentSchedule)
        {
            this.Name = Name;
            this.JoinDate = JoinDate;
            this.Fee = Fee;
            this.PaymentType = paymentSchedule;
        }
        

        //Returns the members details as a string for the member details text block
        public string MemberDetaills()
        {
            string md = $"{Name}\nJoin date: {JoinDate}\nBasic fee: €{Fee}\nPayment schedule: {PaymentType.ToString()} - €{CalculateFees()}\nRenewal date: {RenewalDate()}\nDays to renewal: {DaysToRenewal()}\nMember type: {MemberType}";
            return md;
        }

        //Calculates members fees based upon their payment type
        internal decimal CalculateFees()
        {
            if(PaymentType == PaymentSchedule.Monthly)
            {
                return Fee / 12;
            }
            else if (PaymentType == PaymentSchedule.Biannual)
            {
                return Fee / 2;
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
            DateTime dt = DateTime.Now;
            return dt;
        }
        
        //Calculates days to renewal
        internal int DaysToRenewal()
        {
            return 1;
        }

        //Override for ToString such that the list of members shows names
        public override string ToString()
        {
            return Name;
        }
    }
}
