using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organization.Domain.Commands;

namespace Organization.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateOrganizationCommandTests
    {
        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            var command = new CreateOrganizationCommand();
        }
        public void Dado_um_comando_valido()
        {

        }
    }
}
