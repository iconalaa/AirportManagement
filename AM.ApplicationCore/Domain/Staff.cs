using System;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public decimal Salary { get; set; }

        public override void PassengerType()
        {
            Console.WriteLine("i am staff ");

        }
    }
}
