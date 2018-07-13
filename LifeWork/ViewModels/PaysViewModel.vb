Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class PaysViewModel

    Public Property Id As Long

    <Display(Name:="Nom_Pays", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Nom As String

    <Display(Name:="Abreviation_Pays", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Abreviation As String


    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    <Display(Name:="IdentifiantTelephonique_Pays", ResourceType:=GetType(Resource))>
    Public Property IdentifiantTelephonique As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    Public Sub New()
    End Sub

    Public Sub New(entity As Pays)
        With Me
            .Id = entity.Id
            .Nom = entity.Nom
            .Abreviation = entity.Abreviation
            .IdentifiantTelephonique = entity.IdentifiantTelephonique
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Pays
        Dim entity As New Pays
        With entity
            .Id = Me.Id
            .Nom = Me.Nom
            .Abreviation = Me.Abreviation
            .IdentifiantTelephonique = Me.IdentifiantTelephonique
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
