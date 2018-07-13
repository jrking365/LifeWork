

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class PostulerJobCfg
    Inherits EntityTypeConfiguration(Of PostulerJob)
    Public Sub New()
        'Me.ToTable("Postuler")
        Me.HasKey(Function(e) New With {e.UserId, e.JobsId})
        Me.Property(Function(p) p.Description).IsRequired().HasMaxLength(500)
    End Sub
End Class
