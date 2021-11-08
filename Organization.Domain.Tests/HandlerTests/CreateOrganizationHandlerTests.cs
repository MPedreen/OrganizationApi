using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organization.Domain.Commands;
using Organization.Domain.Commands.Contracts;
using Organization.Domain.Handlers;
using Organization.Domain.Tests.Repository;

namespace Organization.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateOrganizationHandlerTests
    {
        private readonly CreateOrganizationCommand _invalidCommand = new CreateOrganizationCommand("", "", DateTime.Now);
        private readonly CreateOrganizationCommand _validCommand = new CreateOrganizationCommand("Titulo da tarefa", "pedroferreira", DateTime.Now);
        private readonly OrganizationHandler _handler = new OrganizationHandler(new FakeOrganizationRepository());
        private GenericCommandResult _result = new GenericCommandResult();

        public CreateOrganizationHandlerTests()
        {

        }

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Success, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Success, true);
        }
    }
}
