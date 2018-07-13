Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class PersonneDeReferenceViewModel

    Public Property Id As Long

    <Display(Name:="Nom_PersonneDeReference", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Nom As String

    <Display(Name:="Prenom_PersonneDeReference", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Prenom As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    <Display(Name:="Sexe_PersonneDeReference", ResourceType:=GetType(Resource))>
    Public Property Sexe As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    <Display(Name:="Telephone_PersonneDeReference", ResourceType:=GetType(Resource))>
    Public Property Telephone As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    <Display(Name:="Profession_PersonneDeReference", ResourceType:=GetType(Resource))>
    Public Property Profession As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    <Display(Name:="Email_PersonneDeReference", ResourceType:=GetType(Resource))>
    Public Property Email As String

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

    Public Sub New(entity As PersonneDeReference)
        With Me
            .Id = entity.Id
            .CvId = entity.CvId
            .Nom = entity.Nom
            .Prenom = entity.Prenom
            .Sexe = entity.Sexe
            .Telephone = entity.Telephone
            .Profession = entity.Profession
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As PersonneDeReference
        Dim entity As New PersonneDeReference
        With entity
            .Id = Me.Id
            .CvId = Me.CvId
            .Nom = Me.Nom
            .Prenom = Me.Prenom
            .Sexe = Me.Sexe
            .Telephone = Me.Telephone
            .Profession = Me.Profession
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
