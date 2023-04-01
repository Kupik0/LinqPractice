using LinqPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBCustomLinq;
public static class LinQExtensions
{

    public static IEnumerable<UserModel> DenemeWhereTekId(this IEnumerable<UserModel> users)
    {

        var result = new List<UserModel>();

        foreach (var user in users)
        {
            if (user.Id % 2 != 0)
                result.Add(user);
        }

        return result;
    }

    public static IEnumerable<UserModel> DenemeWhereGmailUser(this IEnumerable<UserModel> users)
    {
        var result = new List<UserModel>();

        foreach (var user in users)
        {
            if (user.Email.EndsWith("gmail.com"))
                result.Add(user);
        }

        return result;
    }

    public static UserModel DenemeFirstOrDefault(this IEnumerable<UserModel> users)
    {
        foreach (var user in users)
        {
            return user;
        }

        return null;
    }

    public static UserModel DenemeFirstOrDefaultKuralli(this IEnumerable<UserModel> users)
    {
        foreach (var user in users)
        {
            if (user.Name.Length > 4)
                return user;
        }

        return null;
    }

    public static List<UserModel> DenemeTolist(this IEnumerable<UserModel> users)
    {
        var result = new List<UserModel>();

        foreach (var user in users)
        {
            result.Add(user);
        }

        return result;
    }

}