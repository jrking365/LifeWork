

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class ReferenceCfg
    Inherits EntityTypeConfiguration(Of Reference)
    Public Sub New()
        Me.ToTable("Reference")
        Me.Property(Function(p) p.Titre).IsRequired().HasMaxLength(500)
    End Sub
End Class
