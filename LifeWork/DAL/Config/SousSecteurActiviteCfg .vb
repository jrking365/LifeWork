

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class SousSecteurActiviteCfg
    Inherits EntityTypeConfiguration(Of SousSecteurActivite)
    Public Sub New()
        Me.ToTable("SousSecteurActivite")
        Me.Property(Function(p) p.Libelle).IsRequired().HasMaxLength(500)
    End Sub
End Class
