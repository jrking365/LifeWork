

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class MessagerieCfg
    Inherits EntityTypeConfiguration(Of Messagerie)
    Public Sub New()
        Me.ToTable("Messagerie")
        Me.Property(Function(p) p.Objet).IsRequired().HasMaxLength(500)
        Me.Property(Function(p) p.Contenu).IsRequired().HasMaxLength(500)
    End Sub
End Class
