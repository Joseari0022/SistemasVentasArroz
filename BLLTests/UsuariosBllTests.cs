using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Entidades.Usuarios cl = new Entidades.Usuarios();
           // Assert.IsTrue(UsuariosBll.Guardar(new Entidades.Usuarios(cl)));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListarTodoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaNombreTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetContrasenaTest()
        {
            Assert.Fail();
        }
    }
}