using AspNet.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        private static List<Author> authors;
        private static List<Book> books;

        public IActionResult Index()
        {
            if (authors is null)
            {
                authors = new List<Author>()
                {
                    new Author{Name = "Ivan Freud", BirthDate = DateOnly.Parse("1856-08-29"), DeathDate = DateOnly.Parse("1939-10-13")},
                    new Author{Name = "Ana Lee", BirthDate = DateOnly.Parse("1926-03-21"), DeathDate = DateOnly.Parse("2016-02-23")},
                    new Author{Name = "Mihael Chomsky", BirthDate = DateOnly.Parse("1928-08-29")}
                };
            }
            if (books is null)
            {
                books = new List<Book>()
                {
                    new Book{Name = "Of Light and Dark", Author = authors[2], PublishDate = DateOnly.Parse("1888-05-09"), Description = "Analysis of human desires."},
                    new Book{Name = "Tower in the Sky", Author = authors[1], PublishDate = DateOnly.Parse("1955-11-12"), Description = "A utopia dwells in the skies, meanwhile..."},
                    new Book{Name = "Rising Above", Author = authors[2], PublishDate = DateOnly.Parse("1899-01-02")},
                    new Book{Name = "The Human Trinity", Author = authors[2], PublishDate = DateOnly.Parse("1921-12-11"), Description = "Introduction to the Id, Ego, and Superego."},
                    new Book{Name = "Forest Fire", Author = authors[1], PublishDate = DateOnly.Parse("2005-11-09"), Description = "The flames are rising in the bacground, and fast approaching..."}

                };
            }
            return View(books);
        }

        public IActionResult AuthorIndex()
        {
            if (authors is null)
            {
                authors = new List<Author>()
                {
                    new Author{Name = "Ivan Freud", BirthDate = DateOnly.Parse("1856-08-29"), DeathDate = DateOnly.Parse("1939-10-13")},
                    new Author{Name = "Ana Lee", BirthDate = DateOnly.Parse("1926-03-21"), DeathDate = DateOnly.Parse("2016-02-23")},
                    new Author{Name = "Mihael Chomsky", BirthDate = DateOnly.Parse("1928-08-29")}
                };
            }
            if (books is null)
            {
                books = new List<Book>()
                {
                    new Book{Name = "Of Light and Dark", Author = authors[2], PublishDate = DateOnly.Parse("1888-05-09"), Description = "Analysis of human desires."},
                    new Book{Name = "Tower in the Sky", Author = authors[1], PublishDate = DateOnly.Parse("1955-11-12"), Description = "A utopia dwells in the skies, meanwhile..."},
                    new Book{Name = "Rising Above", Author = authors[2], PublishDate = DateOnly.Parse("1899-01-02")},
                    new Book{Name = "The Human Trinity", Author = authors[2], PublishDate = DateOnly.Parse("1921-12-11"), Description = "Introduction to the Id, Ego, and Superego."},
                    new Book{Name = "Forest Fire", Author = authors[1], PublishDate = DateOnly.Parse("2005-11-09"), Description = "The flames are rising in the background, and fast approaching..."}

                };
            }
            return View(authors);
        }

        // GET: ExamController1/Details/5
        public ActionResult Details(int id)
        {
            return View(books.First(book => book.Id == id));
        }

        // GET: ExamController1/AuthorDetails/5
        public ActionResult AuthorDetails(int id)
        {
            return View(authors.First(author => author.Id == id));
        }

        /*// GET: ExamController1/Create
        public ActionResult Create()
        {
            return View();
        }*/

        // GET: ExamController1/AuthorCreate
        public ActionResult AuthorCreate()
        {
            return View();
        }

        /*// POST: ExamController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                books.Add(book);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/

        // POST: ExamController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AuthorCreate(Author author)
        {
            try
            {
                authors.Add(author);
                return RedirectToAction(nameof(AuthorIndex));
            }
            catch
            {
                return View();
            }
        }

        /*// GET: ExamController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExamController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }*/

        // GET: ExamController1/Delete/5
        public ActionResult AuthorDelete(int id)
        {
            return View(authors.First(author => author.Id == id));
        }

        /*// POST: ExamController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book book)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/

        // POST: ExamController1/AuthorDelete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AuthorDelete(int id, Author author)
        {
            try
            {
                authors.RemoveAll(author => author.Id == id);
                return RedirectToAction(nameof(AuthorIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
