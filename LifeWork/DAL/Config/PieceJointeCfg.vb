

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class PieceJointeCfg
    Inherits EntityTypeConfiguration(Of PieceJointe)
    Public Sub New()
        Me.ToTable("PieceJointe")
    End Sub
End Class
