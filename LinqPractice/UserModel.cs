using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class UserModel
    {
        public int? Id { get; set; } = 1;
        public string? Name { get; set; } = "Kupik";
        public string? Adress { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Email { get; set; } = "mkupik0@gmail.com";
    }
}
