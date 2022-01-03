using System;
using static System.Console;

namespace Manis_Assignment_9_PaintingDemo
{
    class Room
    {
        public int length;
        public int width;
        public int height;
        const int gallons = 350;

        public Room(int l, int w, int h)
        {
            length = l;
            width = w;
            height = h;
        }
        public void RoomArea()
        {
            int longWalls = (length * height) * 2;
            int shortWalls = (width * height) * 2;
            int area = longWalls + shortWalls;
            int cans;

            if(area <= gallons)
            {
                cans = 1;
            }

            else
            {
                cans = 2;
            }

            WriteLine("    Two walls are {0} long and {1} high ", length, height);
            WriteLine("        and the other two walls are {0} long and {1} high ", width, height);
            WriteLine("    Total wall area is {0}, so you will need {1} gallon(s) of paint ", area, cans);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengthArray = { 8, 10, 12, 14, 16, 18, 20, 22};
            int[] widthArray = { 8, 9, 10, 11, 12, 13, 14, 15};
            int[] heightArray = { 8, 8, 9, 9, 10, 10, 11, 11};

            Room[] r = new Room[8];

            for(int i=0; i<8; i++)
            {
                int l = lengthArray[i];
                int w = widthArray[i];
                int h = heightArray[i];
                r[i] = new Room(l, w, h);
                WriteLine(" ");
            }

            for(int i=0; i<8; i++)
            {
                WriteLine("For a {0} X {1} X {2} foot room", lengthArray[i], widthArray[i], heightArray[i]);
                r[i].RoomArea();
                WriteLine(" ");
            }
        }
    }
}