Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class NotificationViewModel

    Public Property Id As Long

    <Display(Name:="Titre_Notification", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Titre As String

    <Display(Name:="Contenu_Notification", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Contenu As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DateEnvoi_Notification", ResourceType:=GetType(Resource))>
    Public Property DateEnvoi As DateTime

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    Public Sub New()
    End Sub

    Public Sub New(entity As Notification)
        With Me
            .Id = entity.Id
            .Titre = entity.Titre
            .Contenu = entity.Contenu
            .DateEnvoi = entity.DateEnvoi
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Notification
        Dim entity As New Notification
        With entity
            .Id = Me.Id
            .Titre = Me.Titre
            .Contenu = Me.Contenu
            .DateEnvoi = Me.DateEnvoi
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
