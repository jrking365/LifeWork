

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class SecteurActiviteCfg
    Inherits EntityTypeConfiguration(Of SecteurActivite)
    Public Sub New()
        Me.ToTable("SecteurActivite")
        Me.Property(Function(p) p.Libelle).IsRequired().HasMaxLength(500)
    End Sub
End Class
