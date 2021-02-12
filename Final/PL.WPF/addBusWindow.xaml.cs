﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BL;

namespace PL.WPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class addBusWindow : Window
    {
        int temp = new int();
        IBL bl = BLFactory.GetBL(1);
        MainWindow Main;
        BO.BUS ThisBus;
        //for add
        public addBusWindow(MainWindow main)
        {
            InitializeComponent();

            //for Refresh
            Main = main;

            //transition to add
            UpdateButton.IsEnabled = false;
            UpdateButton.Opacity = 0;
            addButton.IsEnabled = true;
            addButton.Opacity = 1;
        }
        //for update
        public addBusWindow(int LN, MainWindow main)
        {
            InitializeComponent();

            //transition to update
            addButton.IsEnabled = false;
            addButton.Opacity = 0;
            UpdateButton.IsEnabled = true;
            UpdateButton.Opacity = 1;
            
            //for refresh after finish
            Main = main;

            //for showing current info
            
            try
            {
                ThisBus = bl.GetBUS(LN);
                licenseTBO.Text = ThisBus.LicenseNum.ToString();
                licenseTBO.IsEnabled = false;
                totalTripTBO.Text = ThisBus.TotalTrip.ToString();
                licensingDP.DisplayDate = ThisBus.FromDate;
                licensingDP.SelectedDate = ThisBus.FromDate;
                lastTreatmentDP.DisplayDate = ThisBus.lastime;
                lastTreatmentDP.SelectedDate = ThisBus.lastime;
                kmFromTreatTBO.Text = ThisBus.ckm.ToString();
                kmFromTreatTBO.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show("Bus Not found");
            }

            
            this.Show();
        }

        private void licenseTBO_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (! int.TryParse(licenseTBO.Text, out temp))
            {
                MessageBox.Show("numbers only!");
            }
        }
        private void licenseTBO_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void AddBus(object sender, EventArgs e)
        {
            int LicenseNum = 0;
            double TotalKM = 0;
            double KMSinceRepair = 0;
            bool flag = true;
            if(licensingDP.SelectedDate > DateTime.Now)
            {
                MessageBox.Show("Can't add bus\nplease select past or present time");
                flag = false;
            }
            if (!int.TryParse(licenseTBO.Text, out LicenseNum))
            {
                MessageBox.Show("numbers only!");
                flag = false;
            }
            if (!Double.TryParse(totalTripTBO.Text, out TotalKM))
            {
                MessageBox.Show("numbers only!");
                flag = false;
            }
            if (!Double.TryParse(kmFromTreatTBO.Text, out KMSinceRepair))
            {
                MessageBox.Show("numbers only!");
                flag = false;
            }
            if(flag && (KMSinceRepair > TotalKM))
            {
                MessageBox.Show("KM since last repair cannot be more than total!");
                flag = false;
            }
            if (lastTreatmentDP.SelectedDate > DateTime.Now)
            {
                MessageBox.Show("Can't add bus\nplease select past or present time");
                flag = false;
            }
            if (lastTreatmentDP.SelectedDate < licensingDP.SelectedDate)
            {
                MessageBox.Show("last treatment cannot be before licensing");
                flag = false;
            }
            if(!flag)
            {
                return;
            }
            BO.BUS bus = new BO.BUS{ LicenseNum = LicenseNum, FromDate = (DateTime)licensingDP.SelectedDate, lastime = (DateTime)lastTreatmentDP.SelectedDate, TotalTrip = TotalKM, ckm = KMSinceRepair};
            try
            {
                bl.AddBus(bus);
                this.Close();
                Main.RefreshList(Main.BusesList);
            }
            catch (BO.BadBusIdException ex)
            {
                
                MessageBox.Show(ex.Message + " " + ex.ID);//ye   
            }
            
        }

        private void UpdateBus(object sender, RoutedEventArgs e)
        {
            int LicenseNum = ThisBus.LicenseNum;
            double TotalKM = ThisBus.TotalTrip;
            double KMSoFar = ThisBus.ckm;
            bool flag = true;
            if (licensingDP.SelectedDate > DateTime.Now)
            {
                MessageBox.Show("Can't add bus\nplease select past or present time");
                flag = false;
            }
            if (!int.TryParse(licenseTBO.Text, out LicenseNum))
            {
                MessageBox.Show("numbers only!");
                flag = false;
            }
            if (!Double.TryParse(totalTripTBO.Text, out TotalKM))
            {
                MessageBox.Show("numbers only!");
                flag = false;
            }
            if (lastTreatmentDP.SelectedDate > DateTime.Now)
            {
                MessageBox.Show("Can't add bus\nplease select past or present time");
                flag = false;
            }
            if (lastTreatmentDP.SelectedDate < licensingDP.SelectedDate)
            {
                MessageBox.Show("last treatment cannot be before licensing");
                flag = false;
            }
            if (!flag)
            {
                return;
            }
            BO.BUS bus = new BO.BUS { LicenseNum = LicenseNum, FromDate = (DateTime)licensingDP.SelectedDate, lastime = (DateTime)lastTreatmentDP.SelectedDate, TotalTrip = TotalKM, ckm = KMSoFar};
            try
            {
                bl.UpdateBus(bus);
            }
            catch
            {
                MessageBox.Show("not found or somthing, idk");
            }
            Main.RefreshList(Main.BusesList);
            this.Close();
        }
    }
}
