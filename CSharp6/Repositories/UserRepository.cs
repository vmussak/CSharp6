using CSharp6.Models;
using System.Collections.Generic;
using static System.DateTime;

namespace CSharp6.Repositories
{
    public class UserRepository
    {
        public IEnumerable<User> Get()
        {
            return new List<User>
            {
                new User(1, "José", "Silva", Now, 44444444444),
                new User(2, "Maria", "Oliveira", Now, 11111111111),
                new User(3, "Mario", "Silva", Now, 22222222222),
                new User(4, "Vanilda", "Morais", Now, 12345678954),
                new User(5, "Cida", "Martins", Now, 55555555555),
                new User(6, "Cláudio", "Silveira", Now, 88888888888),
                new User(7, "Guilherme", "Andrade", Now, 78945612365)
            };
        }
    }
}
