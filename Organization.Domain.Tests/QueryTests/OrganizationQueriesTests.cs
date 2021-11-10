using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organization.Domain.Entities;

namespace Organization.Domain.Tests.EntityTests
{
    public class OrganizationQueriesTests
    {
        private List<OrganizationItem> _items;

        public OrganizationQueriesTests()
        {
            _items = new List<OrganizationItem>();
            _items.Add(new OrganizationItem("Tarefa 1", "usuarioA", DateTime.Now));
            _items.Add(new OrganizationItem("Tarefa 1", "usuarioB", DateTime.Now));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_pedroferreira()
        {
            Assert.Fail();
        }
    }
}