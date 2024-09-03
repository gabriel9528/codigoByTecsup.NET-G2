using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirstNet8.Data;

[Table("Producto")]
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

    [StringLength(200)]
    [Unicode(false)]
    public string Tangible { get; set; } = null!;

    public double IvaActual { get; set; }

    public int StockDisponible { get; set; }
}
