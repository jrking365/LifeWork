Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class ExternalLoginConfirmationViewModel
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Pseudo")>
    Public Property UserName As String
End Class

Public Class ManageUserViewModel
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <DataType(DataType.Password)>
    <Display(Name:="Mot de passe actuel")>
    Public Property OldPassword As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <StringLength(100, ErrorMessage:="La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nouveau mot de passe")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmer le nouveau mot de passe")>
    <Compare("NewPassword", ErrorMessage:="Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")>
    Public Property ConfirmPassword As String
End Class

Public Class UpdateUserPassword
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <DataType(DataType.Password)>
    <Display(Name:="Mot de passe actuel")>
    Public Property OldPassword As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <StringLength(100, ErrorMessage:="La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nouveau mot de passe")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmer le nouveau mot de passe")>
    <Compare("NewPassword", ErrorMessage:="Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")>
    Public Property ConfirmPassword As String
End Class

Public Class LoginViewModel
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Pseudo")>
    Public Property UserName As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <DataType(DataType.Password)>
    <Display(Name:="Mot de passe")>
    Public Property Password As String

    <Display(Name:="Mémoriser le mot de passe ?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Pseudo")>
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

    'Mes propres champs
    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Nom", ResourceType:=GetType(Resource))>
    Public Property Nom As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Prenom", ResourceType:=GetType(Resource))>
    Public Property Prenom As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Sexe", ResourceType:=GetType(Resource))>
    Public Property Sexe As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DateNaissance", ResourceType:=GetType(Resource))>
    Public Property DateNaissance As DateTime

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Email", ResourceType:=GetType(Resource))>
    Public Property Email As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Telephone", ResourceType:=GetType(Resource))>
    Public Property Telephone As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Cni", ResourceType:=GetType(Resource))>
    Public Property CNI As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Fonction", ResourceType:=GetType(Resource))>
    Public Property Fonction As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Entreprise", ResourceType:=GetType(Resource))>
    Public Property Entreprise As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="NumeroCompte", ResourceType:=GetType(Resource))>
    Public Property NumeroCompte As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="SiteWeb", ResourceType:=GetType(Resource))>
    Public Property SiteWeb As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Photo", ResourceType:=GetType(Resource))>
    Public Property Photo As Byte()

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Pays", ResourceType:=GetType(Resource))>
    Public Property PaysId As Long
    Public Overridable Property LesPays As List(Of Pays)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="TypeCompte", ResourceType:=GetType(Resource))>
    Public Property TypeCompteId As Long
    Public Overridable Property LesTypeCompte As List(Of TypeCompte)

    Public Property StatutExistant As Boolean? = True

    Public Function GetUser() As ApplicationUser
        Dim user As New ApplicationUser With {
                .PaysId = PaysId,
                .TypeCompteId = TypeCompteId,
                .UserName = UserName,
                .Nom = StrConv(Nom, VbStrConv.Uppercase),
                .Prenom = StrConv(Prenom, VbStrConv.ProperCase),
                .Sexe = Sexe,
                .DateNaissance = DateNaissance,
                .Email = Email,
                .Telephone = Telephone,
                .Cni = CNI,
                .Fonction = Fonction,
                .Entreprise = Entreprise,
                .NumeroCompte = NumeroCompte,
                .SiteWeb = SiteWeb,
                .Photo = Photo,
                .StatutExistant = True,
                .DateCreation = Now
            }
        Return user
    End Function

    Public Function GetUserMinimal() As ApplicationUser
        Dim user As New ApplicationUser With {
                .TypeCompteId = TypeCompteId,
                .UserName = UserName,
                .Email = Email,
                .StatutExistant = True,
                .DateCreation = Now
            }
        Return user
    End Function

End Class