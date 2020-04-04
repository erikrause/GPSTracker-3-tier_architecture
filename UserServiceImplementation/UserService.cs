using DAL.EFIdentity;
using GPSTracker.DAL.EF;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using UserServiceBase;

namespace UserServiceImplementation
{
    public class UserService : IUserService
    {
        private IRepository Repo;


        public UserService(IRepository repo)
        {
            Repo = repo;
        }

        public async Task<ClaimsIdentity> Authenticate(User user, string password)
        {
            ClaimsIdentity claim = null;
            // авторизуем его и возвращаем объект ClaimsIdentity
            claim = await Repo.UserManager.CreateIdentityAsync(user,
                                            DefaultAuthenticationTypes.ApplicationCookie);
            return claim;
        }

        public async Task<IOperationDetails> Create(User user, string password)
        {
            user.Client = new Client();
            User user_exist = await Repo.UserManager.FindByEmailAsync(user.Email);
            if (user_exist == null)
            {
                //user = new User { Email = user.Email, UserName = user.Email };
                var result = await Repo.UserManager.CreateAsync(user, password);
                if (result.Errors.Count() > 0)
                    return new OperationDetails(false, result.Errors.FirstOrDefault(), "");
                // добавляем роль
                await Repo.UserManager.AddToRoleAsync(user.Id, "user");
                // создаем профиль клиента
                //ClientProfile clientProfile = new ClientProfile { Id = user.Id, Address = userDto.Address, Name = userDto.Name };
                //Repo.ClientManager.Create(clientProfile);
                //await Repo.Save();
                return new OperationDetails(true, "Регистрация успешно пройдена", "");
            }
            else
            {
                return new OperationDetails(false, "Пользователь с таким логином уже существует", "Email");
            }
        }
        public void Dispose()
        {
            Repo.Dispose();
        }

        public Task<User> GetCurrent()
        {
            return Repo.Get<User>(HttpContext.Current.User.Identity.GetUserId<int>());
        }
        /*
public Task SetInitialData(User admin, List<string> roles)
{
   throw new NotImplementedException();
}*/
    }
}
