

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class CursusCfg
    Inherits EntityTypeConfiguration(Of Cursus)
    Public Sub New()
        Me.ToTable("Cursus")
        Me.Property(Function(p) p.Diplome).IsRequired().HasMaxLength(500)
        Me.Property(Function(p) p.Structures).IsRequired().HasMaxLength(500)
    End Sub
End Class
