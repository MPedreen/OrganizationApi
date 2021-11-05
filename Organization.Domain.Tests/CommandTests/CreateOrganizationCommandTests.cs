using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organization.Domain.Commands;

namespace Organization.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateOrganizationCommandTests
    {
        private readonly CreateOrganizationCommand _invalidCommand = new CreateOrganizationCommand("", "", DateTime.Now);
        private readonly CreateOrganizationCommand _validCommand = new CreateOrganizationCommand("Titulo da tarefa", "pedroferreira", DateTime.Now);

        public CreateOrganizationCommandTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            var command = new CreateOrganizationCommand("", "", DateTime.Now);
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            var command = new CreateOrganizationCommand("Titulo da Tarefa", "Pedro Ferreira", DateTime.Now);
            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}
