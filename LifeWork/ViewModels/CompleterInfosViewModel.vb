Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class CompleterInfosViewModel

    Public Property id As String

    <Display(Name:="Login", ResourceType:=GetType(Resource))>
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")>
    Public Property UserName As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <StringLength(100, ErrorMessage:="La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Mot de passe")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmer le mot de passe ")>
    <Compare("Password", ErrorMessage:="Le mot de passe et le mot de passe de confirmation ne correspondent pas.")>
    Public Property ConfirmPassword As String

    <Display(Name:="Email", ResourceType:=GetType(Resource))>
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")>
    Public Property Email As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="TypeCompte", ResourceType:=GetType(Resource))>
    Public Property TypeCompteId As Long
    Public Property LesTypesComptes As ICollection(Of TypeCompte)



    <Display(Name:="Nom", ResourceType:=GetType(Resource))>
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")>
    Public Property Nom As String

    <Display(Name:="Prenom", ResourceType:=GetType(Resource))>
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")>
    Public Property Prenom As String

    <Display(Name:="Sexe", ResourceType:=GetType(Resource))>
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")>
    Public Property Sexe As String

    <Display(Name:="DateNaissance", ResourceType:=GetType(Resource))>
    Public Property DateNaissance As DateTime?

    <Display(Name:="Telephone", ResourceType:=GetType(Resource))>
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")>
    Public Property Telephone As String

    <Display(Name:="Cni", ResourceType:=GetType(Resource))>
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    Public Property CNI As String

    <Display(Name:="Photo", ResourceType:=GetType(Resource))>
    Public Property Photo As HttpPostedFileBase
    'Public Property Photo As Byte()

    Public Property StatutExistant As Boolean?
    Public Property DateCreation As DateTime? = Now

    Public Property SecteurActivite As ICollection(Of SecteurActivite)
    Public Property SoussecteurActivite As ICollection(Of SousSecteurActivite)

    Public Sub New()

    End Sub

    Public Sub New(entity As ApplicationUser)
        With Me
            .id = entity.Id
            .TypeCompteId = entity.TypeCompteId
            .UserName = entity.UserName
            .Nom = entity.Nom
            .Prenom = entity.Prenom
            .Sexe = entity.Sexe
            .DateNaissance = entity.DateNaissance
            .Email = entity.Email
            .Telephone = entity.Telephone
            .CNI = entity.Cni
            '.Photo = entity.Photo
            .DateNaissance = entity.DateNaissance
            .StatutExistant = entity.StatutExistant
            .DateCreation = entity.DateCreation


        End With
    End Sub

    Public Function getEntity() As ApplicationUser
        Dim entity As New ApplicationUser

        With entity
            .Id = Me.id
            .TypeCompteId = Me.TypeCompteId
            .UserName = Me.UserName
            .Nom = StrConv(Me.Nom, VbStrConv.Uppercase)
            .Prenom = StrConv(Me.Prenom, VbStrConv.ProperCase)
            .Sexe = Me.Sexe
            .DateNaissance = Me.DateNaissance
            .Email = Me.Email
            .Telephone = Me.Telephone
            .Cni = Me.CNI
            '.Photo = Me.Photo
            .StatutExistant = Me.StatutExistant
            .DateCreation = Me.DateCreation
            .DateNaissance = Me.DateNaissance

            If Photo IsNot Nothing AndAlso Photo.ContentLength > 0 Then
                entity.Photo = New Byte(Photo.ContentLength - 1) {}
                Photo.InputStream.Read(entity.Photo, 0, Photo.ContentLength)
            End If

        End With

        Return entity
    End Function

End Class
