using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Manybuildings
    {
        private int[] list=new int[10];
        public int this[int index] { get { return this.list[index]; } set { this.list[index] = value; } }
        public Manybuildings()
        {
            this.list = new int[10];
        }
    }
}
