

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class CertificationCfg
    Inherits EntityTypeConfiguration(Of Certification)
    Public Sub New()
        Me.ToTable("Certification")
        Me.Property(Function(p) p.Libelle).IsRequired().HasMaxLength(500)
    End Sub
End Class
