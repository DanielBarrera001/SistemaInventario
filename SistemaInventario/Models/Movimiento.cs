﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; // Asegúrate de tener esta importación

namespace SistemaInventario.Models
{
    // Define la enumeración para los tipos de movimiento
    public enum TipoMovimiento
    {
        Ingreso,
        Salida,
        NuevoProducto // Valor para cuando se crea un producto por primera vez
    }

    public class Movimiento
    {
        public int Id { get; set; }

        [Required]
        public TipoMovimiento Tipo { get; set; } // Ahora usa la enum

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int ProductoId { get; set; }

        [ForeignKey("ProductoId")]
        // Agrega esta línea para restringir la eliminación en cascada.
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Producto Producto { get; set; } // Propiedad de navegación
    }
}