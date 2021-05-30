using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projet_de_fin_de_formation_ahz.Models;

namespace projet_de_fin_de_formation_ahz.Controllers
{
    public class Upload_BookController : Controller
    {
        // GET: Upload_Book
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book_info book_Info)
        {
            string ImgName = Path.GetFileNameWithoutExtension(book_Info.BookIMG.FileName);
            string imgextension = Path.GetExtension(book_Info.BookIMG.FileName);
            ImgName = ImgName + DateTime.Now.ToString("yymmssfff") + imgextension;
            book_Info.Image_Book = "../BookCovers/" + ImgName;
            ImgName = Path.Combine(Server.MapPath("../BookCovers/" + ImgName), ImgName);
            book_Info.BookIMG.SaveAs(ImgName);
            using (Model1 mdl1 = new Model1())
            {
                mdl1.Book_info.Add(book_Info);
                mdl1.SaveChanges();
            }

            string PDFName = Path.GetFileNameWithoutExtension(book_Info.BookPDF.FileName);
            string pdfextension = Path.GetExtension(book_Info.BookPDF.FileName);
            PDFName = PDFName + DateTime.Now.ToString("yymmssfff") + pdfextension;
            book_Info.file_book = "../BookPDFs/" + PDFName;
            PDFName = Path.Combine(Server.MapPath("../BookPDFs/" + PDFName), PDFName);
            book_Info.BookPDF.SaveAs(PDFName);
            using (Model1 mdl2 = new Model1())
            {
                mdl2.Book_info.Add(book_Info);
                mdl2.SaveChanges();
            }

            ModelState.Clear();
            return View();
        }
    }
}