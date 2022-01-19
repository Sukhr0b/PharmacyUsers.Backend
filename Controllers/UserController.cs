using Microsoft.AspNetCore.Mvc;
using PharmacyUsers.Backend.DataLayer;
using PharmacyUsers.Backend;

namespace PharmacyUsers.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController(PharmacyDbContext pharmacyDbContext)
        {
            _PharmacyDbContext = pharmacyDbContext;
        }

        private readonly PharmacyDbContext _PharmacyDbContext;

        [HttpGet]
        public IEnumerable<UserModel> getUsers()
        {
            return _PharmacyDbContext.Model;
        }

        [HttpPost]
        public UserModel SignUp([FromForm] UserModel model)
        {
            if (_PharmacyDbContext.Model.FirstOrDefault(user => user.Login == model.Login) == null)
            {
                _PharmacyDbContext.Model.Add(model);
            }
            else
            {
                return new UserModel();
            }
            _PharmacyDbContext.SaveChanges();

            return model;
        }

        [HttpGet("{login}/{password}")]
        public UserModel SignIn(string login, string password)
        {
            var model = _PharmacyDbContext.Model.FirstOrDefault
                (
                    person => person.Login == login && person.Password == password
                );

            if (model == null)
            {
                return new UserModel();
            }

            return model;
        }



    }
}