Imports Microsoft.AspNet.Identity.EntityFramework

' You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
Public Class ApplicationUser
    Inherits IdentityUser

    Public Property PaysId As Long?
    Public Property TypeCompteId As Long
    Public Property MyPassword As String
    Public Property Nom As String
    Public Property Prenom As String
    Public Property NumeroCompte As String
    Public Property DateNaissance As DateTime? = Now
    Public Property Sexe As String
    Public Property Email As String
    Public Property ConfirmEmail As String
    Public Property Telephone As String
    Public Property ConfirmTelephone As String
    Public Property Cni As String
    Public Property Fonction As String
    Public Property Entreprise As String
    Public Property SiteWeb As String
    Public Property Photo As Byte()

    Public Property StatutExistant As Boolean?
    Public Property DateCreation As DateTime?

    Public Overridable Property Pays As Pays
    Public Overridable Property TypeCompte As TypeCompte
    'Public Overridable Property Consultation As ICollection(Of ConsulterCv) = New HashSet(Of ConsulterCv)

    'Public Overridable Property JobsPublier As ICollection(Of Jobs) = New HashSet(Of Jobs)
    'Public Overridable Property JobsAttribuer As ICollection(Of Jobs) = New HashSet(Of Jobs)


    'Public Overridable Property JobsPostuler As ICollection(Of Jobs) = New HashSet(Of Jobs)
    'Public Overridable Property Notes As ICollection(Of NoterJob) = New HashSet(Of NoterJob)
    'Public Overridable Property Commentaires As ICollection(Of Commentaire) = New HashSet(Of Commentaire)
End Class
