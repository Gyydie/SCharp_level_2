using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpLevel_2
{
    class Star_2 : VisualObject
    {
        public Star_2(Point Position, Point Direction, int Size) : base(Position, Direction, new Size(Size, Size))
        {

        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.White, _Position.X, _Position.Y, _Size.Width, _Size.Height);
        }

        public override void Update()
        {
            _Position.X = _Position.X + _Direction.X;
            if (_Position.X < 0 - _Size.Width)
            {
                _Position.X = Game.Width + _Size.Width/2;
            }

        }
    }
}
