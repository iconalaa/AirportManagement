using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        //public Plane(PlaneType boing, int v, DateTime now)
        //{
        //}

        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public override string ToString()
        {
            return $"PlaneId: {PlaneId}, Capacity: {Capacity}, Manufacture Date: {ManufactureDate.ToShortDateString()}, Plane Type: {PlaneType}";
        }

        public ICollection<Flight> Flights { get; set; }

      

    }
}
