

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class PaysCfg
    Inherits EntityTypeConfiguration(Of Pays)
    Public Sub New()
        Me.ToTable("Pays")
        Me.Property(Function(p) p.nom).IsRequired().HasMaxLength(500)
    End Sub
End Class
