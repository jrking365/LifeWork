Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class CommentaireViewModel

    Public Property Id As Long

    <Display(Name:="Contenu_Commentaire", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Contenu As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Jobs", ResourceType:=GetType(Resource))>
    Public Property JobsId As Long
    Public Overridable Property LesJobs As List(Of Jobs)

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="ApplicationUser", ResourceType:=GetType(Resource))>
    Public Property UserEmployeurId As String
    Public Overridable Property LesUserEmployeur As List(Of ApplicationUser)

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="ApplicationUser", ResourceType:=GetType(Resource))>
    Public Property UserPrestataireId As String
    Public Overridable Property LesUserPrestataire As List(Of ApplicationUser)

    Public Sub New()
    End Sub

    Public Sub New(entity As Commentaire)
        With Me
            .Id = entity.Id
            .JobsId = entity.JobsId
            .UserEmployeurId = entity.UserEmployeurId
            .UserPrestataireId = entity.UserPrestataireId
            .Contenu = entity.Contenu
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Commentaire
        Dim entity As New Commentaire
        With entity
            .Id = Me.Id
            .JobsId = Me.JobsId
            .UserEmployeurId = Me.UserEmployeurId
            .UserPrestataireId = Me.UserPrestataireId
            .Contenu = Me.Contenu
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
