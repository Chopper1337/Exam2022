using System;
using System.Collections.Generic;
using System.Windows;

namespace JMG_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static JuniorMember jm1 = new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = PaymentSchedule.Annual };
        static JuniorMember jm2 = new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = PaymentSchedule.Biannual };
        static JuniorMember jm3 = new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = PaymentSchedule.Monthly };

        static Member m1 = new Member() { Name = "Ella Doyle", Fee = 1000, JoinDate = new DateTime(2019, 3, 20), PaymentType = PaymentSchedule.Annual };
        static Member m2 = new Member() { Name = "Fionn Kennedy", Fee = 1000, JoinDate = new DateTime(2018, 8, 15), PaymentType = PaymentSchedule.Biannual };
        static Member m3 = new Member() { Name = "Louise Moore", Fee = 1000, JoinDate = new DateTime(2017, 2, 10), PaymentType = PaymentSchedule.Monthly };

        static SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual };
        static SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual };
        static SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly };

        List<Member> RegMembers = new List<Member>() { m1, m2, m3 };
        List<Member> JunMembers = new List<Member>() { jm1, jm2, jm3 };
        List<Member> SenMembers = new List<Member>() { sm1, sm2, sm3 };
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
