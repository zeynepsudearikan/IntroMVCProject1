using IntroductionToMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IntroductionToMVC.Controllers
{
    public class BookController : Controller
    {


        //book/display?name=Yüzüklerin Efendisi&author=Tolkien&pageNumber=1026&dueDate=2024-02-04
        //yazıldığında istenen bilgiler çıkar
        public IActionResult Display(string name, string author, int pageNumber, DateTime dueDate)
        {
            Book book = new Book
            {
                Name = name,
                Author = author,
                pageNumber = pageNumber,
                dueDate = dueDate
            };
            return View(book);
        }

        
    }
}
