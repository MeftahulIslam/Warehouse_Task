using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Task
{
    class Warehouse
    {
        private static int length;
        private static int breadth;
        private static int height;
        private double freeSpace = 0;
        private static int usableRowBreadth = 6; //for this part I've given the highest row breadth to be 6 for the ease of calculation
        private static int unusableRowBreadth = 2; //with each row comes row with security requirement breadth 2m which 
                                    //is unusable
        private static int securityRequirementHeight = 6; //6 meters of height is predefined as unusabble
        private int type1Count = 0;
        private int type2Count = 0;
        private int type3Count = 0;
        private int typeCustomCount = 0;

        public Warehouse(int objLength, int objBreadth, int objHeight)  //Overloaded Constructor
        {
            length = objLength;
            breadth = objBreadth;
            height = objHeight;
        }

        public Warehouse() { } //Overloaded Constructor

        public static double UsableSpace()
        {
            /*Math used for calculating number of rows in the warehouse:
              let's say there are 'n' number of rows that are usable, then there will be (n-1) number
              of rows that will be unusable because of safety requirements.
              Again, lets say each usable row will have a breadth of 2m 
              And, each unusable row because of safety requirments will have breadth of 2m
              So, 2n + 2(n-1) = 50; //Since 50 is the total breadth of the warehouse
              or, n = 13
              And (n-1) = 12
              So, there will be 13 usable rows of breadth 2m where containers will be placed
              And, there will be 12 unusable rows of breadth 2m for safety requirements.
              So, volume of each each usable row = (100*2*(12-6)) //Since 6m in height will be left out for safety
                                                 = 1200m^3
              So, total usable volume for all the rows = 13*1200 m^3
                                                       = 15600 m^3
             */
            double totalUsableSpace = Warehouse.CalculateNumberOfRows() * (length * usableRowBreadth * (height - securityRequirementHeight));
            return totalUsableSpace;
            
        }
        
        private static double CalculateNumberOfRows()
        {
            double numberOfUsableRows = ((double)breadth + 1 * (unusableRowBreadth)) / (usableRowBreadth+unusableRowBreadth); //since 2n+2(n-1) = 50; 
            return numberOfUsableRows;                                                                             //where n = number of usable row
                                                                                                                   //(n-1) = number of unusable row
        }                                                                                                          //breadth of the warehouse = 50;
        public void SetFreeSpace(double value)
        {
            freeSpace = value;
        }

        public double GetFreeSpace()
        {
            return freeSpace;
        }
        public void SetType1Count(int count)
        {
            type1Count += count;
        }
        public void SetType2Count(int count)
        {
            type2Count += count;
        }
        public void SetType3Count(int count)
        {
            type3Count += count;
        }

        public void setTypeCustomCount(int count)
        {
            typeCustomCount += count;
        }

        public int GetType1Count()
        {
            return type1Count;
        }
        public int GetType2Count()
        {
            return type2Count;
        }
        public int GetType3Count()
        {
            return type3Count;
        }
        public int GetTypeCustomCount()
        {
            return typeCustomCount;
        }

    }
}
