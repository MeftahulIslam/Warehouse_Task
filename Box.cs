using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Task
{
    class Box
    {
        private int length;
        private int breadth;
        private int height;

        public Box(int objLength, int objBreadth, int objHeight)    //Constructor
        {
            length = objLength;
            breadth = objBreadth;
            height = objHeight;
        }

        public Box() { }
        public int CalculateSpaceEach() 
        {
            int volume = length * breadth * height;
            return volume;
        }

        public static int operator *(Box box1, int number)
        {   
            return (box1.CalculateSpaceEach() * number);
        }

        public int GetLength
        {
            get
            {
                return length;
            }
        }

        public int GetBreadth
        {
            get
            {
                return breadth;
            }
        }

        public int GetHeight
        {
            get
            {
                return height;
            }
        }
    }
}
