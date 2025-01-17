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
    /// Interaction logic for addLineStationWindow.xaml
    /// </summary>
    public partial class addLineStationWindow : Window
    {
        int LineId;
        int StationIndex;
        int PrevStation;
        int NextStation;
        int StationId;
        IBL bl = BLFactory.GetBL(1);
        ShowInfo SI;
        
        //Add
        public addLineStationWindow(ShowInfo Si, int ID)
        {
            SI = Si;
            InitializeComponent();

            //to Show
            AddButton.Visibility = Visibility.Visible;

            //to Hide
            UpdateButton.Visibility = Visibility.Collapsed;

            LineIDTBO.Text = ID.ToString();
            LineId = ID;
            LineIDTBO.IsEnabled = false;
        }

        //Update
        public addLineStationWindow(BO.LineStation station, ShowInfo Si)
        {
            InitializeComponent();

            SI = Si;

            //to Show
            UpdateButton.Visibility = Visibility.Visible;

            //to Hide
            AddButton.Visibility = Visibility.Collapsed;


            //preps
            StationIDBO.Text = station.Station.ToString();
            StationId = station.Station;
            StationIDBO.IsEnabled = false;
            LineIDTBO.Text = station.LineID.ToString();
            LineId = station.LineID;
            LineIDTBO.IsEnabled = false;
            NextStationTBO.IsEnabled = false;
            PrevStationTBO.IsEnabled = false;

        }
        
        private void StationIDBO_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (StationIndexTBO.Text != "")
                {
                    if (!int.TryParse(StationIDBO.Text, out StationId))
                    {
                        MessageBox.Show("numbers only!");
                    }
                }
            }
            catch { }
        }

        private void LineIDTBO_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (StationIndexTBO.Text != "")
                {
                    if (!int.TryParse(LineIDTBO.Text, out LineId))
                    {
                        MessageBox.Show("numbers only!");
                    }
                }
            }
            catch
            { }
        }

        private void StationIndexTBO_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (StationIndexTBO.Text != "")
            {
                if (!int.TryParse(StationIndexTBO.Text, out StationIndex))
                {
                    MessageBox.Show("numbers only!");
                    return;
                }
                try
                {
                    if (StationIndex - 1 >= 1)
                    {
                        List<BO.LineStation> tempList = (List<BO.LineStation>)(bl.GetAllLineStationsBy(p => p.LineStationIndex == (StationIndex - 1)).ToList());
                        PrevStationTBO.Text = tempList.Find(p => p.LineID == LineId).Station.ToString();
                    }
                        
                    try
                    {
                        List<BO.LineStation> tempList = bl.GetAllLineStationsBy(p => p.LineStationIndex == StationIndex).ToList();
                        NextStationTBO.Text = (tempList.Find(p => p.LineID == LineId).Station.ToString());
                    }
                    catch(Exception ex)
                    {
                        if (!NextStationTBO.IsEnabled)
                        { MessageBox.Show("ERROR: please enter station index that not going over the last index of the stations"); }
                    }
                }
                catch (BO.BadLSIdException ex)
                {
                    if(ex.ID == 0)
                    {
                        return;
                    }
                    
                }
                catch
                {
                    MessageBox.Show("ERROR: please enter station index first!");
                }
            }
            else
            {
                PrevStationTBO.Text = "";
                NextStationTBO.Text = "";
            }
        }

        private void PrevStationTBO_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (StationIndexTBO.Text != "")
                {
                    if (!int.TryParse(PrevStationTBO.Text, out PrevStation))
                    {
                        MessageBox.Show("numbers only!");
                    }
                }
            }
            catch {; }

        }

        private void NextStationTBO_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (StationIndexTBO.Text != "")
                {
                    if (!int.TryParse(NextStationTBO.Text, out NextStation))
                    {
                        MessageBox.Show("numbers only!");
                    }
                }
            }
            catch {; }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StationId = int.Parse(StationIDBO.Text);
                bl.AddLineStation(NewLineStation());
                SI.Refresh();
                this.Close();
            }
            catch (BO.BadLSIdException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                bl.UpdateLineStation(NewLineStation());
                SI.Refresh();
                this.Close();
            }
            catch (BO.BadLSIdException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private BO.LineStation NewLineStation()
        {
            BO.LineStation NewLineStation = new BO.LineStation();
            NewLineStation.LineID = LineId;
            NewLineStation.LineStationIndex = StationIndex;
            NewLineStation.NextStation = NextStation;
            NewLineStation.PrevStation = PrevStation;
            NewLineStation.Station = StationId;
            return NewLineStation;
        }

    }
}
