Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class CvViewModel

    Public Property Id As Long

    <Display(Name:="Titre_Cv", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Titre As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="User", ResourceType:=GetType(Resource))>
    Public Property UserId As String
    Public Overridable Property LesUser As List(Of ApplicationUser)

    Public Sub New()
    End Sub

    Public Sub New(entity As Cv)
        With Me
            .Id = entity.Id
            .UserId = entity.UserId
            .Titre = entity.Titre
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Cv
        Dim entity As New Cv
        With entity
            .Id = Me.Id
            .UserId = Me.UserId
            .Titre = Me.Titre
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
