﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace SistemasGonzalez
{
    public class Utilidades
    {
        public static int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }

    }
}