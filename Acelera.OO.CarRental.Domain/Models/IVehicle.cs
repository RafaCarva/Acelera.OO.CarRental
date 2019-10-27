using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.CarRental.Domain.Models
{
    interface IVehicle
    {
        float dailyValue { get; set; }
        float  adicionalKmValue { get; set; }
        string board { get; set; }
        string color { get; set; }
        short totalSeat { get; set; }
    }
}
