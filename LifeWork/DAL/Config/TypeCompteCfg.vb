

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class TypeCompteCfg
    Inherits EntityTypeConfiguration(Of TypeCompte)
    Public Sub New()
        Me.ToTable("TypeCompte")
        Me.Property(Function(p) p.Libelle).IsRequired().HasMaxLength(500)
    End Sub
End Class
