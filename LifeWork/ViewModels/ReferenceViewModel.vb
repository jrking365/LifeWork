Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class ReferenceViewModel

    Public Property Id As Long

    <Display(Name:="Titre_Reference", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Titre As String

    <Display(Name:="Description_Reference", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Description As String

    <Display(Name:="Adresse_Reference", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Adresse As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="Annee_Reference", ResourceType:=GetType(Resource))>
    Public Property Annee As DateTime

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Cv", ResourceType:=GetType(Resource))>
    Public Property CvId As Long
    Public Overridable Property LesCv As List(Of Cv)

    Public Sub New()
    End Sub

    Public Sub New(entity As Reference)
        With Me
            .Id = entity.Id
            .CvId = entity.CvId
            .Titre = entity.Titre
            .Description = entity.Description
            .Adresse = entity.Adresse
            .Annee = entity.Annee
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Reference
        Dim entity As New Reference
        With entity
            .Id = Me.Id
            .CvId = Me.CvId
            .Titre = Me.Titre
            .Description = Me.Description
            .Adresse = Me.Adresse
            .Annee = Me.Annee
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
