using System;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class APointWithInnerFactory
    {
        private double x, y;

        private APointWithInnerFactory(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

        private static async Task<(double, double)> GetSomeWorkDoneAsync(double rho, double theta)
        {
            await Task.Delay(1).ConfigureAwait(false);

            double x = rho * Math.Cos(theta);
            double y = rho * Math.Sin(theta);

            return (x, y);
        }

        public class APointInnerFactory
        {
            public static async Task<APointWithInnerFactory> NewPolarPoint(double rho, double theta)
            {
                var result = await GetSomeWorkDoneAsync(rho, theta);

                return new APointWithInnerFactory(result.Item1, result.Item2);
            }

            public static APointWithInnerFactory NewCartesianPoint(double x, double y)
            {
                return new APointWithInnerFactory(x, y);
            }
        }
    }
}