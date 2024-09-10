using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirstDemo.Data;

[Table("PRODUCTO")]
public partial class Producto
{
    [Key]
    public int IdProducto { get; set; }

    public Guid CodProducto { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string NombreProducto { get; set; } = null!;

    [Column("PVP")]
    public double Pvp { get; set; }

    public double PrecioCompra { get; set; }

    public bool Tangible { get; set; }

    public double IvaActual { get; set; }

    public int StockDisponible { get; set; }
}
