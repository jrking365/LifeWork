

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class JobsCfg
    Inherits EntityTypeConfiguration(Of Jobs)
    Public Sub New()
        Me.ToTable("Jobs")
        Me.Property(Function(p) p.Titre).IsRequired().HasMaxLength(500)
        Me.Property(Function(p) p.Description).IsRequired().HasMaxLength(500)
    End Sub
End Class
