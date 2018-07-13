

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class ServiceCfg
    Inherits EntityTypeConfiguration(Of Service)
    Public Sub New()
        Me.ToTable("Service")
        Me.Property(Function(p) p.Titre).IsRequired().HasMaxLength(500)
    End Sub
End Class
