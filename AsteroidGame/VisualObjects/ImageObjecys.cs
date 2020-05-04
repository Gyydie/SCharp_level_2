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
}
