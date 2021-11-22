using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SnackAttack.Domain.Entities;

namespace SnackAttack.Web.Controllers
{
    public class SnackController : ApiControllerBase
    {
        [HttpGet]
        public Snack GetSnack()
        {
            return new Snack
            {
                Name = "Oreos"
            };
        }
    }
}