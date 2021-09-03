using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Rest.Model
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Endereco { get; set; }
        public string Genero { get; set; }


        public Pessoa()
        {

        }

        public Pessoa(long id, string primeiroNome, string ultimoNome, string endereco, string genero)
        {
            Id = id;
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Endereco = endereco;
            Genero = genero;
        }
    }
}
