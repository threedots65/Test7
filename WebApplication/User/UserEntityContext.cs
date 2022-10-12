using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserEntityContext : IEntityContext<User>
    {
        private ConcurrentDictionary<int, User> users = new ConcurrentDictionary<int, User>();

        private int idPoint = 0;

        public User Create(User user)
        {
            var result = new User
            {
                Name = user.Name,
                Id = ++idPoint
            };

            users.TryAdd(idPoint, result);

            return result;
        }

        public bool Delete(int id)
        {
            var user = Find(id);

            bool result = false;

            if (user != null)
            {
                result = users.TryRemove(id, out user);
            }

            return result;
        }

        public bool Edit(int id, User editedUser)
        {
            var user = Find(id);

            bool result = false;

            if (user != null)
            {
                user.Name = editedUser.Name;

                result = true;
            }

            return result;
        }

        public ICollection<User> Get()
        {
            var result = users.Values;

            return result;
        }

        private User Find(int id)
        {
            var result = Get().FirstOrDefault(x => x.Id == id);

            return result;
        }
    }
}
