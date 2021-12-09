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
        private readonly int uniqnumber;
        private static int UniqueNumber = 0;
        public Building()
        {
            UniqueNumber += 1;
            uniqnumber = UniqueNumber;
        }
        public int Floorheight { get { return Height / Numberoffloors; } set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be higher 0 ");

                Height = value * Numberoffloors;
            } }

        public int Numberofapartmentsintheentrance
        { get { return Numberofapartments / Numberofentrances; } set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be more 0 ");

                Numberofapartments = value * Numberofentrances;
            }
        }

        public int Numberofapartmentsperfloor
        {
            get { return Numberofapartmentsintheentrance / Height; }
            set {
                if (value< 0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be more 0 ");

            Numberofapartmentsintheentrance = value* Height;
}
        }
        private Manybuildings Manybuildings;
        public Manybuildings this[int index]
        {
            get { return Manybuildings[index]; }
            set { Manybuildings[index] = value; }
        }
    }
}
