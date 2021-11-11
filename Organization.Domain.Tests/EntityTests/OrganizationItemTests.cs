using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organization.Domain.Entities;

namespace Organization.Domain.Tests.EntityTests
{
    [TestClass]
    public class OrganizationItemTests
    {
        private readonly OrganizationItem _validOrganization = new OrganizationItem("Titulo aqui", "pedroferreira", DateTime.Now);

        [TestMethod]
        public void Dado_um_novo_organization_o_mesmo_nao_pode_ser_concluido()
        {
            Assert.AreEqual(_validOrganization.Done, false);
        }
    }
}