using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organization.Domain.Entities;
using Organization.Domain.Queries;

namespace Organization.Domain.Tests.EntityTests
{
    public class OrganizationQueriesTests
    {
        private List<OrganizationItem> _items;

        public OrganizationQueriesTests()
        {
            _items = new List<OrganizationItem>();
            _items.Add(new OrganizationItem("Tarefa 1", "usuarioA", DateTime.Now));
            _items.Add(new OrganizationItem("Tarefa 2", "usuarioB", DateTime.Now));
            _items.Add(new OrganizationItem("Tarefa 3", "pedroferreira", DateTime.Now));
            _items.Add(new OrganizationItem("Tarefa 4", "usuarioA", DateTime.Now));
            _items.Add(new OrganizationItem("Tarefa 5", "pedroferreira", DateTime.Now));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_pedroferreira()
        {
            var result = _items.AsQueryable().Where(OrganizationQueries.GetAll("pedroferreira"));
        }
    }
}