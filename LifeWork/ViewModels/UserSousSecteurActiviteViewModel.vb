Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class UserSousSecteurActiviteViewModel

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="SousSecteurActivite", ResourceType:=GetType(Resource))>
    Public Property SousSecteurActiviteId As Long
    Public Overridable Property LesSousSecteurActivite As List(Of SousSecteurActivite)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="User", ResourceType:=GetType(Resource))>
    Public Property UserId As String
    Public Overridable Property LesUser As List(Of ApplicationUser)

    Public Sub New()
    End Sub

    Public Sub New(entity As UserSousSecteurActivite)
        With Me
            .SousSecteurActiviteId = entity.SousSecteurActiviteId
            .UserId = entity.UserId
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As UserSousSecteurActivite
        Dim entity As New UserSousSecteurActivite
        With entity
            .SousSecteurActiviteId = Me.SousSecteurActiviteId
            .UserId = Me.UserId
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
