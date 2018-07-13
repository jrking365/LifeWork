

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class NoterJobCfg
    Inherits EntityTypeConfiguration(Of NoterJob)
    Public Sub New()
        Me.ToTable("NoterJob")
    End Sub
End Class
