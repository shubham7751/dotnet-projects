using Blog.Data;
using Blog.Models.Domain;
using Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class AdminTagsController1 : Controller
    {
        private BlogDB _db;
        public AdminTagsController1(BlogDB db)
        {
            _db = db;
                
        }



        [HttpGet]
        
        public IActionResult Add()
        {
            return View(_db.Tags.ToList());
        }
        [HttpPost]
        [ActionName("Insert")]
        public IActionResult Insert(AddTagRequest Add1)
        {
            //mapping add1 to tag domain model
         
            var tag = new Tag
            {
                 Name = Add1.Name,
                 DisplayName = Add1.DisplayName
            };

            
             _db.Tags.Add(tag);
            _db.SaveChanges();



            //to check values coming back in controller
            //var name = add1.Name;
            //var displayName = add1.DisplayName;


            // without using model
            //var name = Request.Form["name"];
            //var displayName = Request.Form["displayName"];
            return View("Add");
        }
    }
}
