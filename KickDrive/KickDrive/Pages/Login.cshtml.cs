using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Service;

namespace KickDrive.Pages
{
    public class LoginModel : PageModel
    {
        public IRepository1<User> Repository1 { get; }
        public LoginModel(IRepository1<User> repository1)
        {
            Repository1= repository1;
        }
        [BindProperty]
        public User User { get; set; }

        public void OnGet(User User)
        {
            var id = Repository1.Insert(User);
        }
        
    }
}