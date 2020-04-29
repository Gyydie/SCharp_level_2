using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel_2.VisualObjects
{
    internal class SpaceShip : VisualObject
    {
        public SpaceShip(Point Position, Point Direction, Size Size, Image Image)
            : base(Position, Direction, Size)
        {

        }
        public override void Draw(Graphics g)
        {

        }
    }
}
