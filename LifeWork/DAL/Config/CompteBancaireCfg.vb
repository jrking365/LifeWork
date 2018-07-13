

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class CompteBancaireCfg
    Inherits EntityTypeConfiguration(Of CompteBancaire)
    Public Sub New()
        Me.ToTable("CompteBancaire")
        Me.Property(Function(p) p.Code).IsRequired().HasMaxLength(500)
    End Sub
End Class
