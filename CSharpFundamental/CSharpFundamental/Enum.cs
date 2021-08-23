using System;

namespace CSharpFundamental
{
    public enum ShippingMethod
    {
        RegularAirMAil = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }
    public class Enum
    {
        public void Ennum()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method);

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

        }
    }
}
