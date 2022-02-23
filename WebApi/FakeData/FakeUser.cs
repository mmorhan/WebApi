using Bogus;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.FakeData
{
    public static class FakeUser
    {
        private static List<User> _users;

        public static List<User> GetUsers(int n)
        {
            if (_users == null)
            {
            _users = new Faker<User>()
                .RuleFor(x => x.UserId, f => f.Random.Int())
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Address, f => f.Address.FullAddress())
                .Generate(n);
            }

        return _users;
        }

    }
}
