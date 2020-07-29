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
    public class Registro_AdminModel : PageModel
    {
     
        public IRepository1<User> Repository1 { get; }
        public Registro_AdminModel(IRepository1<User> repository1)
        {
            Repository1 = repository1;
        }
        [BindProperty]
        public User User { get; set; } 
        public void OnPost(User User)
        {
            Repository1.Insert(User);
        }
        
    }
}