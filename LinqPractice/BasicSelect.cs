using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class BasicSelect
    {

        public void KupikleriSec()
        {

            var users = new List<UserModel>();
            {
                new UserModel { Name = "Kupik", Adress = "Konak", CreateDate = DateTime.Now, Email = "mkupik0@gmail.com", Id = 1 };
            }

            var kupikler = users.Where(x => x.Name == "Kupik").Select(x => x.Name).ToList();
        }


    }
}
