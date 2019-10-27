using Acelera.OO.CarRental.Domain.Models.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.CarRental.Domain.Models
{
    public interface IRental
    {
        float finalKm { get; set; }
        float initialKm { get; set; }
        Vehicle vehicle { get; set; }
        DateTime initialRentalDate { get; set; }
        DateTime finalRentalDate { get; set; }
        Client driver { get; set; }
        List<Accessory> accessories { get; set; }

        void colseRental();
        void setAccessoriesRules();
    }
}
