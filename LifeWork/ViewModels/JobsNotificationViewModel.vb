Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class JobsNotificationViewModel

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Jobs", ResourceType:=GetType(Resource))>
    Public Property JobsId As Long
    Public Overridable Property LesJobs As List(Of Jobs)

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Notification", ResourceType:=GetType(Resource))>
    Public Property NotificationId As String
    Public Overridable Property LesNotification As List(Of Notification)

    Public Sub New()
    End Sub

    Public Sub New(entity As JobsNotification)
        With Me
            .JobsId = entity.JobsId
            .NotificationId = entity.NotificationId
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As JobsNotification
        Dim entity As New JobsNotification
        With entity
            .JobsId = Me.JobsId
            .NotificationId = Me.NotificationId
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
