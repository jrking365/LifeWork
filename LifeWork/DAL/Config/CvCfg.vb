

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class CvCfg
    Inherits EntityTypeConfiguration(Of Cv)
    Public Sub New()
        Me.ToTable("Cv")
        Me.Property(Function(p) p.Titre).IsRequired().HasMaxLength(500)
    End Sub
End Class
