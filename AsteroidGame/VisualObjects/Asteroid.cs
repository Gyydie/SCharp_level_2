using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpLevel_2.VisualObjects
{
    class Asteroid : ImageObjecys, ICollision
    {
        private static readonly Image __Image = Image.FromFile("src\\ast.png");

        public Asteroid(Point Position, Point Direction, int ImageSize) 
            : base(Position, Direction, new Size(ImageSize, ImageSize), __Image)
        {

        }

        public Rectangle Rect => new Rectangle(_Position, _Size);

        public bool CheckCollision(ICollision obj) => Rect.IntersectsWith(obj.Rect);
    }
}
