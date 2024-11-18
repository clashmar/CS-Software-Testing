using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CS_Software_Testing
{
    public class Compass
    {
        

        public Enums.Point Point { get; set; }

        public static Enums.Point Rotate(Enums.Point point, Enums.Direction direction)
        {
            if (direction == Enums.Direction.Right)
            {
                switch (point)
                {
                    case Enums.Point.North:
                        return Enums.Point.East;
                    case Enums.Point.East:
                        return Enums.Point.South;
                    case Enums.Point.South:
                        return Enums.Point.West;
                    default:
                        return Enums.Point.North;
                }
            } else {
                switch (point)
                {
                    case Enums.Point.North:
                        return Enums.Point.West;
                    case Enums.Point.West:
                        return Enums.Point.South;
                    case Enums.Point.South:
                        return Enums.Point.East;
                    default:
                        return Enums.Point.North;
                }
            }
        }  
    }
}
