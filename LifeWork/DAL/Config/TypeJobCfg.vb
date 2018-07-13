

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class TypeJobCfg
    Inherits EntityTypeConfiguration(Of TypeJob)
    Public Sub New()
        Me.ToTable("TypeJob")
        Me.Property(Function(p) p.Libelle).IsRequired().HasMaxLength(500)
    End Sub
End Class
