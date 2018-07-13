

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class CompetenceCfg
    Inherits EntityTypeConfiguration(Of Competence)
    Public Sub New()
        Me.ToTable("Competence")
        Me.Property(Function(p) p.Libelle).IsRequired().HasMaxLength(500)
    End Sub
End Class
