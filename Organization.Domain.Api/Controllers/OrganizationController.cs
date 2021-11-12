using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Organization.Domain.Commands;
using Organization.Domain.Commands.Contracts;
using Organization.Domain.Entities;
using Organization.Domain.Handlers;
using Organization.Domain.Repositories;

namespace Organization.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/organizations")]
    public class OrganizationController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<OrganizationItem> GetAll([FromServices] IOrganizationRepository repository)
        {
            return repository.GetAll("pedroferreira");
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create([FromBody] CreateOrganizationCommand command, [FromServices] OrganizationHandler handler)
        {
            command.User = "pedroferreira";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}