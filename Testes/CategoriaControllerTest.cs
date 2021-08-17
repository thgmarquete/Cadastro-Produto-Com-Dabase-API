using API.Controllers;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;
using Xunit;

namespace Testes
{
    public class CategoriaControllerTest
    {
        private readonly Mock<DbSet<Category>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Category _categoria;
        public CategoriaControllerTest()
        {
            _mockSet = new Mock<DbSet<Category>>();
            _mockContext = new Mock<Context>();
            _categoria = new Category { Id = 1, Descricao = "Teste Categoria" };
        }

        [Fact]

        public async Task Get_Categoria()
        {
            var service = new CategoriesController(_mockContext.Object);

            await service.GetCategory(1);

            _mockSet.Verify(m => m.FindAsync(1), Times.Once());
        }
    }
}
