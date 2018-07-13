

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class ConsulterCvCfg
    Inherits EntityTypeConfiguration(Of ConsulterCv)
    Public Sub New()
        Me.HasKey(Function(e) New With {e.CvId, e.UserId})
        Me.Property(Function(p) p.DateConsulter).IsRequired()
    End Sub
End Class
