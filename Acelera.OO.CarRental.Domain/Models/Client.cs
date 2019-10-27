using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.CarRental.Domain.Models
{
    public class Client : IClient
    {
        public string name { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string cnh { get; set; }
    }
}
