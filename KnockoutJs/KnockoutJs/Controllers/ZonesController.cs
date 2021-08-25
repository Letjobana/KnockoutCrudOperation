using Geotab.Checkmate;
using KnockoutJs.Models;
using KnockoutJs.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KnockoutJs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZonesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ZonesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAllZones([FromForm] Credential credential)
        {
            try
            {
                API api = new API(credential.Username, null, credential.SessionId, credential.Database, credential.Server);
                if (!_unitOfWork.ApiRepository.Aunthenticate(api))
                    return Unauthorized();
                else
                    _unitOfWork.ApiRepository.GetZones();
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
