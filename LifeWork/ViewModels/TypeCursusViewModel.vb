Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class TypeCursusViewModel

    Public Property Id As Long

    <Display(Name:="Type_TypeCursus", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Type As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    Public Sub New()
    End Sub

    Public Sub New(entity As TypeCursus)
        With Me
            .Id = entity.Id
            .Type = entity.Type
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As TypeCursus
        Dim entity As New TypeCursus
        With entity
            .Id = Me.Id
            .Type = Me.Type
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
