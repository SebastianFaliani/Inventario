﻿using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Modelos
{
    public class ModelValesParaReporte
    {
        public string Almacenista { get; set; }
        public string NombreSolicitante { get; set; }
        public DateTime Solicitud { get; set; }
        public DateTime Entrega { get; set; }
        public int Cantidad { get; set; }

        public ModelValesParaReporte(Vale vale)
        {
            NombreSolicitante = string.Format("{0} {1}", vale.Solicitante.Nombre, vale.Solicitante.Apellidos);
            Almacenista = string.Format("{0} {1}", vale.EncargadoDeAlmacen.Nombre, vale.EncargadoDeAlmacen.Apellidos);
            Solicitud = vale.FechaHoraSolicitud;
            Entrega = vale.FechaEntrega;
            Cantidad = vale.MaterialesPrestados.Count;
        }
    }
}
