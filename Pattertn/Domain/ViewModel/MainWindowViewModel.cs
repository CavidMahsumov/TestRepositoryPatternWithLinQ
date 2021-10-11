using Pattertn.Commands;
using Pattertn.DataAccses.SQLServer;
using Pattertn.Domain.Abstarction;
using Pattertn.Domain.AdditionalClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattertn.Domain.ViewModel
{
    class MainWindowViewModel:BaseViewModel
    {
        public RelayCommand AddCommand { get; set; }
        private readonly IRepository<Book> _repo;
        private ObservableCollection<Book> allBooks;

        public MainWindowViewModel(IRepository<Book> repo)
        {
            _repo = repo;
            AllBooks = _repo.GetAllData();
            currentBook = new Book();
            AddCommand = new RelayCommand((sender) =>
            {

                currentBook.Id_Author = 1;
                currentBook.Id_Category = 1;
                currentBook.Id_Press = 1;
                currentBook.Id_Themes = 1;
                _repo.AddData(CurrentBook);
                AllBooks = _repo.GetAllData();
            });
         
        }


        public ObservableCollection<Book> AllBooks
        {
            get { return allBooks; }
            set { allBooks = value; OnPropertyChanged(); }
        }

        private Book currentBook;

        public Book CurrentBook
        {
            get { return currentBook; }
            set { currentBook = value;OnPropertyChanged(); }
        }


    }
}
