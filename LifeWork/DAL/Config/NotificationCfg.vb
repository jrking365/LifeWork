

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class NotificationCfg
    Inherits EntityTypeConfiguration(Of Notification)
    Public Sub New()
        Me.ToTable("Notification")
        Me.Property(Function(p) p.Titre).IsRequired().HasMaxLength(500)
    End Sub
End Class
