using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SampleTestApplication;

namespace scaffold
{

[ApiController]
[Route("[controller]")] 
   public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User
        [HttpGet]
        public async Task<List<User>> Index()
        {
            return _context.User.ToList();
        }
        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
           _context.User.Add(user);
           _context.SaveChanges();
           return user;
        }
       
    }
}
