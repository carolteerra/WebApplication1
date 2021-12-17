using System.Collections.Generic;
using WebApplication1.Data.Converter.Implementations;
using WebApplication1.Data.VO;
using WebApplication1.Model;
using WebApplication1.Repository.Generic;

namespace WebApplication1.Business.Implementations {
    public class BookBusinessImplementation : IBookBusiness {
        private readonly IRepository<Book> _repository;

        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository) {
            _repository = repository;
            _converter = new BookConverter();
        }

        // Method responsible for returning all people,
        public List<BookVO> FindAll() {
            return _converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one person by ID
        public BookVO FindByID(long id) {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Method responsible to crete one new person
        public BookVO Create(BookVO person) {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        // Method responsible for updating one person
        public BookVO Update(BookVO person) {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id) {
            _repository.Delete(id);
        }

        //public BookVO Create(BookVO book) {
            //throw new System.NotImplementedException();
        //}

        BookVO IBookBusiness.FindByID(long id) {
            throw new System.NotImplementedException();
        }

       // List<BookVO> IBookBusiness.FindAll() {
         //   throw new System.NotImplementedException();
        //}

        //public BookVO Update(BookVO book) {
          //  throw new System.NotImplementedException();
        }
    }

