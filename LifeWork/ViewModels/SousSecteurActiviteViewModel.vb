Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class SousSecteurActiviteViewModel

    Public Property Id As Long

    <Display(Name:="Libelle_SousSecteurActivite", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Libelle As String

    <Display(Name:="Description_SousSecteurActivite", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Description As String

    <Display(Name:="Code_SousSecteurActivite", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Code As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="SecteurActivite", ResourceType:=GetType(Resource))>
    Public Property SecteurActiviteId As Long
    Public Overridable Property LesSecteurActivite As List(Of SecteurActivite)

    Public Sub New()
    End Sub

    Public Sub New(entity As SousSecteurActivite)
        With Me
            .Id = entity.Id
            .SecteurActiviteId = entity.SecteurActiviteId
            .Libelle = entity.Libelle
            .Description = entity.Description
            .Code = entity.Code
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As SousSecteurActivite
        Dim entity As New SousSecteurActivite
        With entity
            .Id = Me.Id
            .SecteurActiviteId = Me.SecteurActiviteId
            .Libelle = Me.Libelle
            .Description = Me.Description
            .Code = Me.Code
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
