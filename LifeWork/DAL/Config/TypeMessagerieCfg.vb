

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class TypeMessagerieCfg
    Inherits EntityTypeConfiguration(Of TypeMessagerie)
    Public Sub New()
        Me.ToTable("TypeMessagerie")
        Me.Property(Function(p) p.Titre).IsRequired().HasMaxLength(500)
    End Sub
End Class
