using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Building
    {
        private int Height { get; set; }
        private int Numberoffloors { get; set; }
        private int Numberofapartments { get; set; }
        private int Numberofentrances { get; set; }
        private int uniqnumber { get; set; }
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
    }
}
