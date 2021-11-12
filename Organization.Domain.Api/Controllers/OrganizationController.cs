using System;
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

        [Route("done")]
        [HttpGet]
        public IEnumerable<OrganizationItem> GetAllDone([FromServices] IOrganizationRepository repository)
        {
            return repository.GetAllDone("pedroferreira");
        }

        [Route("undone")]
        [HttpGet]
        public IEnumerable<OrganizationItem> GetAllUnDone([FromServices] IOrganizationRepository repository)
        {
            return repository.GetAllUndone("pedroferreira");
        }

        [Route("done/today")]
        [HttpGet]
        public IEnumerable<OrganizationItem> GetDoneForToday([FromServices] IOrganizationRepository repository)
        {
            return repository.GetByPeriod("pedroferreira", DateTime.Now, true);
        }

        [Route("undone/today")]
        [HttpGet]
        public IEnumerable<OrganizationItem> GetUnDoneForToday([FromServices] IOrganizationRepository repository)
        {
            return repository.GetByPeriod("pedroferreira", DateTime.Now, false);
        }

        [Route("done/tomorrow")]
        [HttpGet]
        public IEnumerable<OrganizationItem> GetDoneForTomorrow([FromServices] IOrganizationRepository repository)
        {
            return repository.GetByPeriod("pedroferreira", DateTime.Now.AddDays(1), true);
        }

        [Route("undone/tomorrow")]
        [HttpGet]
        public IEnumerable<OrganizationItem> GetUnDoneForTomorrow([FromServices] IOrganizationRepository repository)
        {
            return repository.GetByPeriod("pedroferreira", DateTime.Now.AddDays(1), false);
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create([FromBody] CreateOrganizationCommand command, [FromServices] OrganizationHandler handler)
        {
            command.User = "pedroferreira";
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpPut]
        public GenericCommandResult Update(
           [FromBody] UpdateOrganizationCommand command,
           [FromServices] OrganizationHandler handler
       )
        {
            command.User = "pedroferreira";
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("mark-as-done")]
        [HttpPut]
        public GenericCommandResult MarkAsDone(
            [FromBody] MarkOrganizationAsDoneCommand command,
            [FromServices] OrganizationHandler handler
        )
        {
            command.User = "pedroferreira";
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("mark-as-undone")]
        [HttpPut]
        public GenericCommandResult MarkAsUnDone(
            [FromBody] MarkOrganizationAsUnDoneCommand command,
            [FromServices] OrganizationHandler handler
        )
        {
            command.User = "pedroferreira";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}