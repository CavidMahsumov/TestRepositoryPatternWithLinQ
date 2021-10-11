using Pattertn.Domain.Abstarction;
using Pattertn.Domain.AdditionalClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattertn.DataAccses.SQLServer
{
    class BookRepository : IBookRepository
    {
        public DataClassesDataContext dataContext { get; set; }

        public BookRepository()
        {
            dataContext = new DataClassesDataContext();
        }

        public Book GetData(int Id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Book> GetAllData()
        {
            var books = from b in dataContext.Books
                        select b;
            return ObserverHelper.ToObservableCollection(books);
        }

        public void AddData(Book data)
        {
            dataContext.Books.InsertOnSubmit(data);
            dataContext.SubmitChanges();
        }

        public void UpdateData(Book data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Book data)
        {
            throw new NotImplementedException();
        }
    }
}
