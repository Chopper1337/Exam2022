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
        //All the members
        static JuniorMember jm1 = new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = PaymentSchedule.Annual };
        static JuniorMember jm2 = new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = PaymentSchedule.Biannual };
        static JuniorMember jm3 = new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = PaymentSchedule.Monthly };

        static Member m1 = new Member() { Name = "Ella Doyle", Fee = 1000, JoinDate = new DateTime(2019, 3, 20), PaymentType = PaymentSchedule.Annual };
        static Member m2 = new Member() { Name = "Fionn Kennedy", Fee = 1000, JoinDate = new DateTime(2018, 8, 15), PaymentType = PaymentSchedule.Biannual };
        static Member m3 = new Member() { Name = "Louise Moore", Fee = 1000, JoinDate = new DateTime(2017, 2, 10), PaymentType = PaymentSchedule.Monthly };

        static SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual };
        static SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual };
        static SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly };

        //Lists for all the members
        List<JuniorMember> JunMembers = new List<JuniorMember>() { jm1, jm2, jm3 };
        List<Member> RegMembers = new List<Member>() { m1, m2, m3 };
        List<SeniorMember> SenMembers = new List<SeniorMember>() { sm1, sm2, sm3 };
        List<string> AllMembers = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (JuniorMember j in JunMembers)
                AllMembers.Add(j.Name);

            foreach (SeniorMember s in SenMembers)
                AllMembers.Add(s.Name);

            foreach (Member r in RegMembers)
                AllMembers.Add(r.Name);

            lstbxList.ItemsSource = AllMembers;
            txblkMemberDetails.Text = "";
        }

        private void rbReg_Checked(object sender, RoutedEventArgs e)
        {
            lstbxList.ItemsSource = RegMembers;
        }

        private void rbSenior_Checked(object sender, RoutedEventArgs e)
        {
            lstbxList.ItemsSource = SenMembers;
        }

        private void rbJunior_Checked(object sender, RoutedEventArgs e)
        {
            lstbxList.ItemsSource = JunMembers;
        }

        private void rbAll_Checked(object sender, RoutedEventArgs e)
        {
            lstbxList.ItemsSource = AllMembers;
        }

        private void lstbxList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (lstbxList.SelectedItem != null)
            {
                string name = lstbxList.SelectedItem.ToString();

                foreach (JuniorMember j in JunMembers)
                    if (j.Name == name)
                    {
                        txblkMemberDetails.Text = j.MemberDetails();
                        break;
                    }

                foreach (Member r in RegMembers)
                    if (r.Name == name)
                    {
                        txblkMemberDetails.Text = r.MemberDetails();
                        break;
                    }

                foreach (SeniorMember s in SenMembers)
                    if (s.Name == name)
                    {
                        txblkMemberDetails.Text = s.MemberDetails();
                        break;
                    }
            }
        }
    }
}
