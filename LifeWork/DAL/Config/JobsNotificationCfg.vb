

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class JobsNotificationCfg
    Inherits EntityTypeConfiguration(Of JobsNotification)
    Public Sub New()
        'Me.ToTable("JobsNotification")
        Me.HasKey(Function(e) New With {e.JobsId, e.NotificationId})
    End Sub
End Class
