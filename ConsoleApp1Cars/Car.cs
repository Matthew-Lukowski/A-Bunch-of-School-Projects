using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Cars
{
    class Car
    {
        public string model, make, color;
        public int year, mph, mphChange;

        internal int GoFast(int mph, int mphChange)
        {
            mph = mph + mphChange;
            return mph;
        }
    }
}
