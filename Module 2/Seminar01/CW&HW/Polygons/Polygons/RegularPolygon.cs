using System;

namespace Polygons
{
    public class RegularPolygon
    {
        private int Sides { get; set; }
        private double Radius { get; set; }

        public RegularPolygon(int sides = 0, double radius = 0)
        {
            Sides = sides;
            Radius = radius;
        }

        public double Perimeter
        {
            get { return Sides * 2 * Radius * Math.Tan(Math.PI / Sides); }
        }

        public double Square
        {
            get { return (Radius * Perimeter / 2); }
        }

        public string PolygonData()
        {
            {
                return "Число сторон многогольника: " + Sides.ToString() + "\n " + "Радиус вписанной окружности: " +
                       Radius.ToString() + "\n " + "Площадь многогольника: " + this.Square.ToString() + "\n " +
                       "Периметр многогольника: " +
                       this.Perimeter.ToString();
            }
        }
    }
}

