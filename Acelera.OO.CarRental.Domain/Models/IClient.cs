using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.CarRental.Domain.Models
{
    public interface IClient
    {
        string name { get; set; }
        string cpf { get; set; }
        string email { get; set; }
        string cnh { get; set; }
        //public List<Rental> rentalHistory { get; set; }
    }
}
