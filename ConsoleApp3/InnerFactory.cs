using System;

namespace ConsoleApp3
{
    public class PointWithInnerFactory
    {
        private double x, y;

        private PointWithInnerFactory(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

        public static class PointInnerFactory
        {
            public static PointWithInnerFactory NewPolarPoint(double rho, double theta)
            {
                return new PointWithInnerFactory(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }

            public static PointWithInnerFactory NewCartesianPoint(double x, double y)
            {
                return new PointWithInnerFactory(x, y);
            }
        }
    }
}