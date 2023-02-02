using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Hotel_DIO.Models
{
    public class Suite
    {

        public Suite(string tipoSuite, int capacidadeSuite, decimal valorDiaria)
        {

            this.TipoSuite = tipoSuite;
            this.CapacidadeSuite = capacidadeSuite;
            this.ValorDiaria = valorDiaria;

        }

        public string TipoSuite { get; set; }
        public int CapacidadeSuite { get; set; }
        public decimal ValorDiaria { get; set; }

    }
}