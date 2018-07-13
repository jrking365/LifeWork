Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class SecteurActiviteViewModel

    Public Property Id As Long

    <Display(Name:="Libelle_SecteurActivite", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Libelle As String

    <Display(Name:="Description_SecteurActivite", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Description As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    Public Sub New()
    End Sub

    Public Sub New(entity As SecteurActivite)
        With Me
            .Id = entity.Id
            .Libelle = entity.Libelle
            .Description = entity.Description
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As SecteurActivite
        Dim entity As New SecteurActivite
        With entity
            .Id = Me.Id
            .Libelle = Me.Libelle
            .Description = Me.Description
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
