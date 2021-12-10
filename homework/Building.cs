using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Building
    {
        private int Height;
        private int Numberoffloors;
        private int Numberofapartments;
        private int Numberofentrances;
        private int uniqnumber;
        static int indexer = 0;
        private static int UniqueNumber = 0;
        private int index;
        public Building()
        {
            index = indexer++;
        }
        public Building(int Height, int Numberoffloors, int Numberofapartments, int Numberofentrances)
        {
            index = indexer++;
            this.Height = Height;
            this.Numberoffloors = Numberoffloors;
            this.Numberofapartments = Numberofapartments;
            this.Numberofentrances = Numberofentrances;
        }
        public int Floorheight
        {
            get { return Height; }
            set
            {
                if (Height < 0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be higher 0 ");
                else
                {
                    Height = value;
                }

            }
        }

        public int Numberofapartmentsintheentrance
        {
            get { return Numberofentrances; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be more 0 ");

                else
                { Numberofentrances = value; }
            }
        }

        public int Numberofapartmentsperfloor
        {
            get { return Numberoffloors; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be more 0 ");

                else
                {
                    Numberoffloors = value;
                }
            }
        }
        public int Numberof
        {
            get { return Numberofapartments; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be more 0 ");

                else
                {
                    Numberofapartments = value;
                }

            }
        }
        public double GetHighOfStorey(int NumberOfEntances)
        {
            if (NumberOfEntances <= Numberofentrances && Numberofentrances > 0)
            {
                return Height / NumberOfEntances * NumberOfEntances;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Такогo этажа нет");
            }
        }
        public int GetApartNumberOfentrances()
        {
            return Numberofapartments / Numberofentrances;
        }
        public int GetApartNumberOfStorey()
        {
            return GetApartNumberOfentrances() / Numberofentrances;
        }
    }
}
