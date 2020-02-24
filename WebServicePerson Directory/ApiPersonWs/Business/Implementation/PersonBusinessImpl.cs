using System.Collections.Generic;
using ApiPersonWs.Model;
using ApiPersonWs.Repository;

namespace ApiPersonWs.Business.Implementation
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _repository;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        //Método responsável por criar uma nova pessoa
        //No banco aqui é onde persiste os dados
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }
        
        //Busca por um Id Person
        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        //Onde realiza o Update de um person
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
