﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratorioWebApi.Data.Procedures
{
    public partial class sp_muestras_para_informarResult
    {
        [Column("ID Muestra")]
        public int IDMuestra { get; set; }
        [Column("Nombre Paciente")]
        public string NombrePaciente { get; set; }
        [Column("Apellido Paciente")]
        public string ApellidoPaciente { get; set; }
        public string Práctica { get; set; }
        [Column("Fecha Recolección")]
        public DateTime? FechaRecolección { get; set; }
        [Column("Fecha prometida informe")]
        public DateTime? Fechaprometidainforme { get; set; }
        public string Estado { get; set; }
    }
}