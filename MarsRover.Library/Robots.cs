using System;

namespace MarsRover.Library
{
    public class Robots
    {
        bool kontrol = false;
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        public string Direction { get; set; }

        public bool xycontrol (int x,int y)
        {
            if(x<5 && x>=0 && y>=0 && y < 5)
            {
                kontrol = true;
            }
            else
            {
                kontrol = false;
            }
            return kontrol;
        }
        public bool DirectionControl(string Direction) {
        if(Direction=="N" || Direction=="W" || Direction =="S" || Direction=="E")
            {
                kontrol = true;
                 }
            else
            {
                kontrol = false;
            }
        return kontrol;
        }
    }
}
