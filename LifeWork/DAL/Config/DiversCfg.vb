

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class DiversCfg
    Inherits EntityTypeConfiguration(Of Divers)
    Public Sub New()
        Me.ToTable("Divers")
        Me.Property(Function(p) p.Titre).IsRequired().HasMaxLength(500)
    End Sub
End Class
