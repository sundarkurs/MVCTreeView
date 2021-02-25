using SimpleTreeViewInMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleTreeViewInMVC.Web.Controllers
{
    public class TreeViewController : Controller
    {
        // GET: TreeView
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Simple()
        {
            List<Folder> all = new List<Folder>();

            all.Add(new Folder() { Id = 1, Name = "Images", ParentId = 0 });
            all.Add(new Folder() { Id = 2, Name = "Datasheet", ParentId = 0 });

            all.Add(new Folder() { Id = 3, Name = "Website", ParentId = 1 });
            all.Add(new Folder() { Id = 4, Name = "Sales", ParentId = 1 });
            all.Add(new Folder() { Id = 5, Name = "Add-on", ParentId = 1 });
            all.Add(new Folder() { Id = 6, Name = "Product", ParentId = 1 });

            all.Add(new Folder() { Id = 7, Name = "Hero Images", ParentId = 3 });
            all.Add(new Folder() { Id = 8, Name = "Footer Images", ParentId = 3 });

            all.Add(new Folder() { Id = 9, Name = "Enterprise", ParentId = 2 });

            all.Add(new Folder() { Id = 10, Name = "Broachers", ParentId = 9 });
            all.Add(new Folder() { Id = 11, Name = "Invoices", ParentId = 9 });

            return View(all.OrderBy(a => a.ParentId).ToList());
        }
    }
}