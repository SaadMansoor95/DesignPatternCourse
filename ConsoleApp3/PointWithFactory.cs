using System;

namespace ConsoleApp3
{
    public static class PointFactory
    {
        public static PointWithFactory NewPolarPoint(double rho, double theta)
        {
            return new PointWithFactory(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        public static PointWithFactory NewCartesianPoint(double x, double y)
        {
            return new PointWithFactory(x, y);
        }
    }

    public class PointWithFactory
    {
        private double x, y;

        public PointWithFactory(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }
    }
}