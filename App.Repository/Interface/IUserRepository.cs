using App.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<AppApplicationUser> GetAll();
        AppApplicationUser Get(string id);
        void Insert(AppApplicationUser entity);
        void Update(AppApplicationUser entity);
        void Delete(AppApplicationUser entity);
    }
}