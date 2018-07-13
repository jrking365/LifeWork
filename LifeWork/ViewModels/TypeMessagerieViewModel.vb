Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class TypeMessagerieViewModel

    Public Property Id As Long

    <Display(Name:="Titre_TypeMessagerie", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Titre As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    Public Sub New()
    End Sub

    Public Sub New(entity As TypeMessagerie)
        With Me
            .Id = entity.Id
            .Titre = entity.Titre
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As TypeMessagerie
        Dim entity As New TypeMessagerie
        With entity
            .Id = Me.Id
            .Titre = Me.Titre
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
