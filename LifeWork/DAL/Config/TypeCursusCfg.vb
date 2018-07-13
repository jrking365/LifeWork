

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class TypeCursusCfg
    Inherits EntityTypeConfiguration(Of TypeCursus)
    Public Sub New()
        Me.ToTable("TypeCursus")
        Me.Property(Function(p) p.Type).IsRequired().HasMaxLength(500)
    End Sub
End Class
