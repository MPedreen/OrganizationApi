using Microsoft.AspNetCore.Mvc;
using Organization.Domain.Commands;
using Organization.Domain.Commands.Contracts;

namespace Organization.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/organizations")]
    public class OrganizationController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public GenericCommandResult Create([FromBody] CreateOrganizationCommand command)
        {

        }
    }
}