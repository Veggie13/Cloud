using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlexDraw;

namespace Cloud
{
    class Nebula : IDrawable
    {
        private const double G = 1;

        public void Draw(IDrawAPI api)
        {
            throw new NotImplementedException();
        }

        public bool Visible
        {
            get { throw new NotImplementedException(); }
        }

        public PointD Origin
        {
            get { throw new NotImplementedException(); }
        }

        public RectangleD Bounds
        {
            get { throw new NotImplementedException(); }
        }

        public RectangleD LastBounds
        {
            get { throw new NotImplementedException(); }
        }

        public event DrawableModifiedEvent Modified;

        private class Particle
        {
            public PointD Pos = new PointD();
            public double Mass = 0.0;
        }
    }
}
