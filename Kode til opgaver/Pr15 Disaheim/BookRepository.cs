//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pr15_Disaheim
//{
//    public class BookRepository
//    {
//        private List<Book>? books = new List<Book>();

//        public void AddBook(Book book)
//        {
//            books.Add(book);
//        }
//        public Book? GetBook(string itemId)
//        {
//            Book? book = null;
//            if (books.Count > 0)
//            {
//                foreach (Book b in books)
//                {
//                    if (b.ItemId == itemId)
//                    {
//                        book = b; break;
//                    }
//                }
//            }
//            return book;
//        }
//        public Double GetTotalValue()
//        {
//            Utility utility = new Utility();
//            Double totalValue = 0;
//            foreach (Book b in books)
//            {
//                totalValue += utility.GetValueOfBook(b);
//            }
//            return totalValue;
//        }
//    }
//}
