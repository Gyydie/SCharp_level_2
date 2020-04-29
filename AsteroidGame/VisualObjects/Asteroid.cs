using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpLevel_2.VisualObjects
{
    internal abstract class ImageObjecys : VisualObject
    {
        private readonly Image _Image;

        protected ImageObjecys(Point Position, Point Direction, Size Size, Image Image) 
            : base(Position, Direction, Size)
        {
            _Image = Image;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(_Image, _Position.X, _Position.Y, _Size.Width, _Size.Height);
        }
    }


    class Asteroid : ImageObjecys
    {
        private static readonly Image __Image = Image.FromFile("src\\ast.png");

        public Asteroid(Point Position, Point Direction, int ImageSize) 
            : base(Position, Direction, new Size(ImageSize, ImageSize), __Image)
        {

        }

        public override void Draw(Graphics g)
        {

        }

        //public override void Update()
        //{
        //    _Position.X += _Direction.X;

        //    if (_Position.X < 0)
        //    {
        //        _Position.X = Game.Width + _Size.Width;
        //    }
        //}
    }
}
