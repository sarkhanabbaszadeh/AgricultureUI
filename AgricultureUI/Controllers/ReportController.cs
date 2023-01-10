using AgricultureUI.Models;
using ClosedXML.Excel;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace AgricultureUI.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticsReport()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workBook = excelPackage.Workbook.Worksheets.Add("Sənəd1");

            workBook.Cells[1, 1].Value = "Məhsul adı";
            workBook.Cells[1, 2].Value = "Katergoriyası";
            workBook.Cells[1, 3].Value = "Məhsul sayı";

            workBook.Cells[2, 1].Value = "Tibbi Web sayt";
            workBook.Cells[2, 2].Value = "Web sayt";
            workBook.Cells[2, 3].Value = "5";

            workBook.Cells[3, 1].Value = "Kargo Web sayt";
            workBook.Cells[3, 2].Value = "Web sayt";
            workBook.Cells[3, 3].Value = "2";

            workBook.Cells[4, 1].Value = "Tibbi Desktop app";
            workBook.Cells[4, 2].Value = "Desktop app";
            workBook.Cells[4, 3].Value = "2";


            var bytes = excelPackage.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spereadsheetml.sheet", "StaticHesabat.xlsx");
        }

        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels= new List<ContactModel>();
            using(var context=new AgricultureContext())
            {
                contactModels=context.Contacts.Select(x=>new ContactModel
                {
                    ContactID=x.ContactID,
                    ContactName=x.Name,
                    ContactDate=x.Date,
                    ContactMail=x.Mail,
                    ContactMessage=x.Message
                }).ToList();
            }

            return contactModels;
        }
        public IActionResult ContactsReport()
        {
            using(var workBook=new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Mesaj Listi");
                workSheet.Cell(1, 1).Value = "M_ID";
                workSheet.Cell(1, 2).Value = "Göndərən";
                workSheet.Cell(1, 3).Value = "E-poçtası";
                workSheet.Cell(1, 4).Value = "Mesaj";
                workSheet.Cell(1, 5).Value = "Tarix";

                int contactRowCount = 2;

                foreach (var item in ContactList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.ContactID;
                    workSheet.Cell(contactRowCount, 2).Value = item.ContactName;
                    workSheet.Cell(contactRowCount, 3).Value = item.ContactMail;
                    workSheet.Cell(contactRowCount, 4).Value = item.ContactMessage;
                    workSheet.Cell(contactRowCount, 5).Value = item.ContactDate;
                    contactRowCount++;
                }

                using(var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MessageReport.xlsx");
                }
            }


        }

        public List<NewModel> NewList()
        {
            List<NewModel> newModels = new List<NewModel>();
            using (var context = new AgricultureContext())
            {
                newModels = context.Newses.Select(x => new NewModel
                {
                    ID = x.NewsID,
                    Title = x.Title,
                    Date = x.Date,
                    Description = x.Description,
                    Status = x.Status
                }).ToList();
            }

            return newModels;
        }

        public IActionResult NewsReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Məlumat Listi");
                workSheet.Cell(1, 1).Value = "M_ID";
                workSheet.Cell(1, 2).Value = "Başlıq";
                workSheet.Cell(1, 3).Value = "Tarix";
                workSheet.Cell(1, 4).Value = "Məlumat";
                workSheet.Cell(1, 5).Value = "Vəziyyət";

                int contactRowCount = 2;

                foreach (var item in NewList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.ID;
                    workSheet.Cell(contactRowCount, 2).Value = item.Title;
                    workSheet.Cell(contactRowCount, 3).Value = item.Date;
                    workSheet.Cell(contactRowCount, 4).Value = item.Description;
                    workSheet.Cell(contactRowCount, 5).Value = item.Status;
                    contactRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewsReport.xlsx");
                }
            }


        }


    }
}
