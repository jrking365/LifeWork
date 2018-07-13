

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class PersonneDeReferenceCfg
    Inherits EntityTypeConfiguration(Of PersonneDeReference)
    Public Sub New()
        Me.ToTable("PersonneDeReference")
        Me.Property(Function(p) p.Nom).IsRequired().HasMaxLength(500)
        Me.Property(Function(p) p.Profession).IsRequired().HasMaxLength(500)
    End Sub
End Class
