using System;
using System.Collections.Generic;
using System.Text;
using Acelera.OO.CarRental.Domain.Models.ValueObjects;

namespace Acelera.OO.CarRental.Domain.Models
{
    public class Rental : IRental
    {
        public float finalKm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float initialKm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Vehicle vehicle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime initialRentalDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime finalRentalDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Client driver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Accessory> accessories { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void colseRental()
        {
            throw new NotImplementedException();
        }

        public void setAccessoriesRules()
        {
            throw new NotImplementedException();
        }
    }
}
