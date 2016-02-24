using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormDemo
{
    abstract class Shape
    {
        public Color Colour;
        public float Thickness;


        public Shape(Color colour, float thickness)
        {
            this.Colour = colour;
            this.Thickness = thickness;
        }

        public abstract void Draw(Graphics g, Pen pen);

        public abstract void Update(Point point);

        public abstract void Delete(Point point, float threshold);
    }
}
