using Microsoft.AspNetCore.Mvc;
using ServerSide__Validations.DataContext;
using ServerSide__Validations.Models;

namespace ServerSide__Validations.Controllers
{
    public class UserRegistrationController : Controller
        
    {
        private readonly ApplicationDbContext _context;

        public UserRegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserInfo model)
        {
            
            if(ModelState.IsValid && model.Id==0)
            {


                _context.Add(model);
                ModelState.AddModelError("", "Data Submitted SuccessFully!");

                _context.SaveChanges();



            }
            else
            { if(!ModelState.IsValid) {
                       ModelState.AddModelError("", "Please Enter Correct Information");

                }

            }
         
           
            
            return View(model);
        }



    }
}
