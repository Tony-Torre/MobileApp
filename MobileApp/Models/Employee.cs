using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Models
{
    class Employee
    {
        public string Matricola { get; set; } = null!;

        public string? Nominativo { get; set; }

        public string? Ruolo { get; set; }

        public string? Reparto { get; set; }

        public int? Eta { get; set; }

        public string? Indirizzo { get; set; }

        public string? Citta { get; set; }

        public string? Provincia { get; set; }

        public string? Cap { get; set; }

        public string? Telefono { get; set; }
    }
}
