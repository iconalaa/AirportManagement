using System;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public override void PassengerType()
        {
            Console.WriteLine("i am traveller");
        }
    }
}
