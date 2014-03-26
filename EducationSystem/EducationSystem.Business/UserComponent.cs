using EducationSystem.Data;
using EducationSystem.Infrastructure;
using EducationSystem.Model;
using EducationSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystem.Business
{
    public class UserComponent
    {
        #region  Interface Objects

        //Create object for the User repository Interface
        private readonly IUserRepository _userRepository = new UserRepository();

        #endregion

        public List<UserModel> GetAllUsers()
        {
            try
            {
                return _userRepository.All<User>().AsEnumerable().Select(s => new UserModel()
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    MiddleName = s.MiddleName,
                    LastName = s.LastName
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
