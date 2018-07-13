

Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class CommentaireCfg
    Inherits EntityTypeConfiguration(Of Commentaire)
    Public Sub New()
        Me.ToTable("Commentaire")
        Me.Property(Function(p) p.Contenu).IsRequired().HasMaxLength(500)
    End Sub
End Class
