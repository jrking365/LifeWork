Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class NoterJobViewModel

    Public Property Id As Long

    '<Display(Name:="NoteEmployeur_NoterJob", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <RegularExpression("^(\d+(((\,))\d+)?)$", ErrorMessageResourceName:="DataType_Decimal", ErrorMessageResourceType:=GetType(Resource))> _
    Public Property NoteEmployeur As String = "0"

    '<Display(Name:="NotePrestataire_NoterJob", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <RegularExpression("^(\d+(((\,))\d+)?)$", ErrorMessageResourceName:="DataType_Decimal", ErrorMessageResourceType:=GetType(Resource))> _
    Public Property NotePrestataire As String = "0"

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="Jobs", ResourceType:=GetType(Resource))>
    Public Property JobsId As Long
    Public Overridable Property LesJobs As List(Of Jobs)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="User_Employeur", ResourceType:=GetType(Resource))>
    Public Property UserEmployeurId As String
    Public Overridable Property LesUserEmployeur As List(Of ApplicationUser)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="User_Prestataire", ResourceType:=GetType(Resource))>
    Public Property UserPrestataireId As String
    Public Overridable Property LesUserPrestataire As List(Of ApplicationUser)

    Public Sub New()
    End Sub

    Public Sub New(entity As NoterJob)
        With Me
            .Id = entity.Id
            .JobsId = entity.JobsId
            .UserEmployeurId = entity.UserEmployeurId
            .UserPrestataireId = entity.UserPrestataireId

            .NoteEmployeur = entity.NoteEmployeur
            .NotePrestataire = entity.NotePrestataire
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As NoterJob
        Dim entity As New NoterJob
        With entity
            .Id = Me.Id
            .JobsId = Me.JobsId
            .UserEmployeurId = Me.UserEmployeurId
            .UserPrestataireId = Me.UserPrestataireId

            .NoteEmployeur = Me.NoteEmployeur
            .NotePrestataire = Me.NotePrestataire
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class

