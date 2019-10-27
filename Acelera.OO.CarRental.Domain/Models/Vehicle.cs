using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.CarRental.Domain.Models
{
    public class Vehicle : IVehicle
    {
        public float dailyValue { get; set; }
        public float adicionalKmValue { get; set; }
        public string board { get; set; }
        public string color { get; set; }
        public short totalSeat { get; set; }
    }
}
