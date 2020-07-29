using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
