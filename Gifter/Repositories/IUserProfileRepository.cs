
using Gifter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gifter.Repositories
{
    public interface IUserProfileRepository
    {
        public List<UserProfile> GetAll();
        public UserProfile GetById(int id);
        public void Add(UserProfile userProfile);
        public void Update(UserProfile userProfile);
        public void Delete(int id);

    }
}