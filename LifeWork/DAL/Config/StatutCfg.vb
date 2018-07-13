

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class StatutCfg
    Inherits EntityTypeConfiguration(Of Statut)
    Public Sub New()
        Me.ToTable("Statut")
        Me.Property(Function(p) p.Libelle).IsRequired().HasMaxLength(500)
    End Sub
End Class
