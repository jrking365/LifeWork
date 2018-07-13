

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class UserSousSecteurActiviteCfg
    Inherits EntityTypeConfiguration(Of UserSousSecteurActivite)
    Public Sub New()
        Me.HasKey(Function(e) New With {e.UserId, e.SousSecteurActiviteId})
    End Sub
End Class
