using LinqPractice;
using System.Security.Cryptography.X509Certificates;
using TBCustomLinq;



public class Program
{
    private static void Main(string[] args)
    {
        var users = new List<UserModel>()
        {
            new UserModel() { Name = "Kupik", Adress = "Konak", CreateDate = DateTime.Now, Email = "mkupik0@gmail.com", Id = 1 }
    
        };
        var linqUser = users
                        //.Where(i => i.Id % 2 != 0)
                        //.Where(i => i.Email.EndsWith("gmail.com"))
                        //.Where(i => i.Id > 5)
                        .ToList();
       

        var DenemeLinqUser = users
                            .DenemeWhereTekId()
                            .DenemeWhereGmailUser()
                            .DenemeTolist();

       BasicSelect basicSelect = new BasicSelect();

        basicSelect.KupikleriSec();


Console.WriteLine("İlk User {0}", users.FirstOrDefault().Name);

        Console.WriteLine("İlk User {0}", linqUser.FirstOrDefault().Name);

        Console.WriteLine("User Sayisi {0}", DenemeLinqUser.Count);
        Console.ReadLine();
    }
}