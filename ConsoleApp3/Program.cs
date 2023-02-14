using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(1, 2, CoordinateSystem.Polar);

            Console.WriteLine("Point: " + point);

            var factoryCartesianPoint = PointFactory.NewCartesianPoint(1, 2);
            var factoryPolarPoint = PointFactory.NewPolarPoint(1, 2);

            Console.WriteLine("Point Factory: " + factoryCartesianPoint);
            Console.WriteLine("Point Factory: " + factoryPolarPoint);

            var innerfactoryPoint = PointWithInnerFactory.PointInnerFactory.NewCartesianPoint(1, 2);

            Console.WriteLine("Point inner Factory" + innerfactoryPoint);

            // ==>Another Example Starts...
            var factory = new SavingAccountFactory();
            var citiAccount = factory.GetSavingAccount("CITI-123456");
            var nationalAccount = factory.GetSavingAccount("NATIONAL-123456");

            Console.WriteLine(
                $"Citi account balance: {citiAccount.Balance} National account balance: {nationalAccount.Balance}");

            var asyncFactory = APointWithInnerFactory.APointInnerFactory.NewPolarPoint(1, 2).Result;
            var asyncFactory1 = APointWithInnerFactory.APointInnerFactory.NewPolarPoint(1, 2);
        }
    }
}