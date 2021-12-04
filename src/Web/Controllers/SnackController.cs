using Microsoft.AspNetCore.Mvc;
using SnackAttack.Application.Common.Interfaces;
using SnackAttack.Domain.Entities;

namespace SnackAttack.Web.Controllers
{
    public class SnackController : ApiControllerBase
    {
        private ISnackService _snackService;
        public SnackController(ISnackService snackService)
        {
            _snackService = snackService;
        }

        [HttpGet]
        public async Task<List<Snack>> GetSnack()
        {
            var snacks = await _snackService.GetAllSnacks();

            return snacks;
        }
    }
}