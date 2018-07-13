Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class ConsulterCvViewModel

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DateConsulter_ConsulterCv", ResourceType:=GetType(Resource))>
    Public Property DateConsulter As DateTime = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Cv", ResourceType:=GetType(Resource))>
    Public Property CvId As Long
    Public Overridable Property LesCv As List(Of Cv)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="User", ResourceType:=GetType(Resource))>
    Public Property UserId As String
    Public Overridable Property LesUser As List(Of ApplicationUser)

    Public Sub New()
    End Sub

    Public Sub New(entity As ConsulterCv)
        With Me
            .CvId = entity.CvId
            .UserId = entity.UserId
            .DateConsulter = entity.DateConsulter
        End With
    End Sub

    Public Function getEntity() As ConsulterCv
        Dim entity As New ConsulterCv
        With entity
            .CvId = Me.CvId
            .UserId = Me.UserId
            .DateConsulter = Me.DateConsulter
        End With
        Return entity
    End Function
End Class
