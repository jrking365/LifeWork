Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class DiversViewModel

    Public Property Id As Long

    <Display(Name:="Titre_Divers", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Titre As String

    <Display(Name:="Commentaire_Divers", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Commentaire As String

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

    Public Sub New(entity As Divers)
        With Me
            .Id = entity.Id
            .CvId = entity.CvId
            .Titre = entity.Titre
            .Commentaire = entity.Commentaire
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Divers
        Dim entity As New Divers
        With entity
            .Id = Me.Id
            .CvId = Me.CvId
            .Titre = Me.Titre
            .Commentaire = Me.Commentaire
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
