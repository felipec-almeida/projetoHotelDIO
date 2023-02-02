using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Hotel_DIO.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {

            this.DiasReservados = diasReservados;

        }
        public List<Pessoa>? Pessoas { get; set; }
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            this.Pessoas = hospedes;
            Console.WriteLine("Os seguintes hóspedes foram Cadastrados:");
            foreach (var pessoa in Pessoas)
            {

                Console.WriteLine($"Nome: {pessoa.Nome} | Sobrenome: {pessoa.Sobrenome}");

            }

        }

        public void CadastrarSuite(Suite suite)
        {

            this.Suite = suite;
            Console.WriteLine("A seguinte Suíte foi cadastrada:");
            Console.WriteLine($"Tipo: {suite.TipoSuite} | Capacidade: {suite.CapacidadeSuite} | Dias Reservados: {this.DiasReservados} | Valor da Diária: {suite.ValorDiaria}");
        }

        public int ObterQuantidadeHospedes() {

            return Pessoas.Count;

        } 

        public decimal CalcularValorHospedagem() {

            if(DiasReservados > 10) {

                decimal desconto = 0.10M;
                decimal valor = (Suite.ValorDiaria * DiasReservados);
                decimal valorDesconto = (valor * desconto);
                
                valor -= valorDesconto;
                return valor;

            } else {

                return (Suite.ValorDiaria * DiasReservados);

            }
            

        } 

    }
}