﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LaboratorioWebApi.Data.Entities;

public partial class Convenios
{
    public int CodOs { get; set; }

    public string NomOs { get; set; }

    public decimal ArancelUb { get; set; }

    public bool EsActivo { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<ConveniosPracticas> ConveniosPracticas { get; set; } = new List<ConveniosPracticas>();

    public virtual ICollection<Pacientes> Pacientes { get; set; } = new List<Pacientes>();
}