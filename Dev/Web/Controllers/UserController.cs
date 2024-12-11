using Microsoft.AspNetCore.Mvc;
using Model;
using NHibernate;
using System.Xml;

namespace Web.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        [Route("User/GetUsers")]
        public List<User> GetUsers()
        {
            

            return new Action.User.GetUser.GetUsers().GetUsersAction();
        }


    }
}
