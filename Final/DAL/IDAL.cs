﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DLAPI
{
    public interface IDAL
    {
        #region User
        void AddUser(User user);
        User GetUser(string UserName);
        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetAllUsersBy(Predicate<User> perdicate);
        void UpdateUser(string UserName, User user);
        User DeleteUser(string UserName);
        #endregion

        #region Station
        void AddStation(Station station);
        IEnumerable<Station> GetAllStations();
        IEnumerable<Station> GetAllStationsBy(Predicate<Station> perdicate);
        Station GetStation(int Code);
        void UpdateStation(int Code, Station station);
        void UpdateStation(int Code, Action<Station> update);
        Station DeleteStation(int Code);
        #endregion

        #region AdjacentStation

        void AddAdjacentStations(AdjacentStations adjacentstation);

        AdjacentStations GetAdjacentStations(int station1, int station2);        

        IEnumerable<AdjacentStations> GetAllAdjacentStations();

        void UpdateAdjacentStations(AdjacentStations adjacentstations);

        AdjacentStations RemoveAdjacentStations(int station1, int station2);        

        #endregion

        #region BUS
        void AddBus(BUS bus);
        BUS GetBUS(int LicenseNum);        
        IEnumerable<BUS> GetAllBuses();
        IEnumerable<BUS> GetAllBusesBy(Predicate<BUS> perdicate);
        void UpdateBus(int LicenseNum, BUS Bus);
        BUS RemoveBus(int LicenseNum);
        #endregion

        #region Line
        void AddLine(Line line);
        Line GetLine(int ID, int code);
        IEnumerable<Line> GetAllLines();
        IEnumerable<Line> GetAllLinesBy(Predicate<Line> perdicate);
        void UpdateLine(int ID, Line line);
        Line DeleteLine(int ID, int Code);
        #endregion

        #region Trip
        void AddTrip(Trip trip);
        Trip GetTrip(int ID);
        IEnumerable<Trip> GetAllTrips();
        IEnumerable<Trip> GetAllTripsBy(Predicate<Trip> perdicate);
        void UpdateTrip(int ID, Trip trip);
        Trip DeleteTrip(int ID);
        #endregion

        #region BusOnTrip
        void AddBusOnTrip(BusOnTrip busontrip);
        BusOnTrip GetBusOnTrip(int ID);
        IEnumerable<BusOnTrip> GetAllBusOnTrip();
        IEnumerable<BusOnTrip> GetAllBusOnTripBy(Predicate<Line> perdicate);
        void UpdateBusOnTrip(int ID, BusOnTrip busontrip);
        BusOnTrip DeleteBusOnTrip(int ID);
        #endregion

        #region LineStation
        void AddLineStation(LineStation station);

        IEnumerable<LineStation> GetAllLineStations();

        IEnumerable<LineStation> GetAllLineStationsBy(Predicate<LineStation> perdicate);

        LineStation GetLineStation(int Code, int line);


        void UpdateLineStation(LineStation station);


        LineStation DeleteLineStation(int Code, int line);

        #endregion

        #region LineTrip

        void AddLineTrip(LineTrip linetrip);
        LineTrip GetLineTrip(int ID);
        IEnumerable<LineTrip> GetAllLineTrips();
        IEnumerable<LineTrip> GetAllLineTripsBy(Predicate<LineTrip> perdicate);
        void UpdateLineTrip(int ID, LineTrip linetrip);
        LineTrip DeleteLineTrip(int ID);


        #endregion
    }
}
