using API_Rest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Rest.Services.Imp
{
    public class PessoaServiceI : IPessoaService
    {
        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }

        public void Delete(long id)
        {
            
        }

        public List<Pessoa> FindAll()
        {
            throw new NotImplementedException();
        }

        public Pessoa FindByID(long id)
        {
            return new Pessoa
            {
                Id = 1, PrimeiroNome = "Edilberto", Endereco = "Rua B", Genero = "Macho", UltimoNome = "Lima"
            };
        }

        public Pessoa Update(long id)
        {
            throw new NotImplementedException();
        }
    }
}
