using System.Collections.Generic;
using ApiPersonWs.Model;

namespace ApiPersonWs.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

        bool Exists(long id);
    }
}
