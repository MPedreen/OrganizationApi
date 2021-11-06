using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organization.Domain.Commands;
using Organization.Domain.Handlers;

namespace Organization.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateOrganizationHandlerTests
    {
        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            var command = new CreateOrganizationCommand("", "", DateTime.Now);
            var handler = new OrganizationHandler(null);
            Assert.Fail();
        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            Assert.Fail();
        }
    }
}
