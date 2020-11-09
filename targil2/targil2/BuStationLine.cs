﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    class BuStationLine : IComparable
    {
        BuStation current;
        double KFL; // Km From Last
        double TFL; // Time From Last
        public BuStation GSStation //GS for GetSet
        {
            get
            {
                return current;
            }
            set
            {
                current = value;
            }
        }
        public double GSKFL //GS for GetSet
        {
            get
            {
                return KFL;
            }
            set
            {
                KFL = value;
            }
        }
        public double GSTFL //GS for GetSet
        {
            get
            {
                return TFL;
            }
            set
            {
                TFL = value;
            }
        }
        public BuStationLine(BuStation newbustation, double newKFL, double newTFL)
        {
            current = newbustation;
            KFL = newKFL;
            TFL = newTFL;
        }
        public BuStationLine()
        {
            current = new BuStation();
            KFL = 0;
            TFL = 0;
        }

        public int CompareTo(object obj)
        {
            int thiss, otherr;
            BuStationLine other = (BuStationLine)obj;
            int.TryParse(other.current.GSID, out otherr);
            int.TryParse(current.GSID, out thiss);
            if (thiss > otherr)
            {
                return 1;
            }
            if(thiss < otherr)
            {
                return -1;
            }
            return 0;
        }
    }
}
