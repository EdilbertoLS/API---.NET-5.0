using API_Rest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API_Rest.Services.Imp
{
    public class PessoaServiceI : IPessoaService
    {
        private volatile int count;

        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }

        public void Delete(long id)
        {
            
        }

        public List<Pessoa> FindAll()
        {
            List<Pessoa> lista = new List<Pessoa>();
            for (int i = 0; i < 8; i++)
            {
                Pessoa pessoa =   MockPessoa(i);
                lista.Add(pessoa);
            }
            return lista;
        }

    

        public Pessoa FindByID(long id)
        {
            return new Pessoa
            {
                Id = IncrementAndGet(), PrimeiroNome = "Edilberto", Endereco = "Rua B", Genero = "Macho", UltimoNome = "Lima"
            };
        }

        public Pessoa Update(Pessoa pessoa)
        {

            return pessoa;

        }




        private Pessoa MockPessoa(int i)
        {
            return new Pessoa
            {
                Id = IncrementAndGet(),
                PrimeiroNome = "Nome Pessoa "+i,
                UltimoNome = "Sobrenome "+i,
                Endereco = "Endereco "+i,
                Genero = "Genero ",
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
