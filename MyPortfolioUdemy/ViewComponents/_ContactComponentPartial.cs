using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.contactsTitle = context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.contactsDescription = context.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.contactsPhone1 = context.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.contactsPhone2 = context.Contacts.Select(x => x.Phone2).FirstOrDefault();
            ViewBag.contactsEmail1 = context.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.contactsEmail2 = context.Contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.contactsAddress = context.Contacts.Select(x => x.Address).FirstOrDefault();
            return View();
        }
    }
}
