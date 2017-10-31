﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;

namespace WebSistemaGonzalez.UI.Registros
{
    public partial class ProductosWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdProductoTextBox.Text);
            Productos productos = ProductosBll.Buscar(u => u.IdProductos == id);
            if (productos != null)
            {
                DescripcionTextBox.Text = productos.Descripcion;
                CantidadTextBox.Text = productos.Cantidad.ToString();
                PrecioTextBox.Text = productos.Precio.ToString();
                FechaTextBox.Text = productos.FechaCreacion.ToString();
            }
            else
            {
              //  Utilidades.ShowToastr(this, "No Existe", "Ingresar Usuario Existente", "warning");
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            if (IsValid)
            {
                if (productos.IdProductos != 0)
                {
                    ProductosBll.Modificar(productos);
                    //Utilidades.ShowToastr(this, "El Usuario", " Se Modifico Correctamente", "Success");
                }
                else
                {
                    productos = Llenar();
                    ProductosBll.Guardar(productos);
                   // Utilidades.ShowToastr(this, "El Usuario", " Se Guardo Correctamente", "Success");

                }
            }
        }

        private Productos Llenar()
        {
          Productos productos = new Productos();
            productos.Descripcion = DescripcionTextBox.Text;
            productos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            productos.Precio = Convert.ToInt32(PrecioTextBox.Text);
            productos.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);

            return productos;
        }
    }
}