﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel_2.VisualObjects
{
    internal class Bullet : CollisionObject
    {
        private const int __BilletSizeX = 20;
        private const int __BilletSizeY = 5;
        private const int __BulletSpeed = 15;

        public Bullet(int Position): base(new Point (0, Position), Point.Empty, new Size(__BilletSizeX, __BilletSizeY))
        {
        }

        public override void Draw(Graphics g)
        {
            var rect = new Rectangle(_Position, _Size);
            g.FillEllipse(Brushes.Red, rect);
            g.DrawEllipse(Pens.White, rect);
        }

        public override void Update()
        {
            _Position = new Point(_Position.X + __BulletSpeed, _Position.Y);
        }
    }
}
