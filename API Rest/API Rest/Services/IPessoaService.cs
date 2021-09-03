using API_Rest.Model;
using System.Collections.Generic;

namespace API_Rest.Services
{
    public interface IPessoaService
    {
        Pessoa Create(Pessoa pessoa);
        Pessoa FindByID(long id);
        List<Pessoa> FindAll();
        Pessoa Update(long id);
        void Delete(long id);
    }
}
