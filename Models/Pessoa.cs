using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Hotel_DIO.Models
{
    public class Pessoa
    {
        /// <summary>
        ///     Cria o Construtor do Objeto Pessoa.
        /// </summary>
        /// <param name="nome">Atributo: Nome da Pessoa</param>
        /// <param name="sobrenome">Atributo: Sobrenome da Pessoa</param>
        public Pessoa(string nome, string sobrenome) {

            this.Nome = nome;
            this.Sobrenome = sobrenome;

        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

    }
}