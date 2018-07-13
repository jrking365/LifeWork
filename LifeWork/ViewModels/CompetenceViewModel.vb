Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class CompetenceViewModel

    Public Property Id As Long

    <Display(Name:="Libelle_Competence", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Libelle As String

    <Display(Name:="Description_Competence", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Description As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Cv", ResourceType:=GetType(Resource))>
    Public Property CvId As Long
    Public Overridable Property LesCv As List(Of Cv)

    Public Sub New()
    End Sub

    Public Sub New(entity As Competence)
        With Me
            .Id = entity.Id
            .CvId = entity.CvId
            .Libelle = entity.Libelle
            .Description = entity.Description
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Competence
        Dim entity As New Competence
        With entity
            .Id = Me.Id
            .CvId = Me.CvId
            .Libelle = Me.Libelle
            .Description = Me.Description
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
