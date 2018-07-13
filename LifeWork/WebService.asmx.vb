Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Web.Script.Services
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService

    Public Sub New()
        Me.New(New UserManager(Of ApplicationUser)(New UserStore(Of ApplicationUser)(New ApplicationDbContext())))
    End Sub

    Public Sub New(manager As UserManager(Of ApplicationUser))
        UserManager = manager
    End Sub

    Public Property UserManager As UserManager(Of ApplicationUser)

    Private db As New ApplicationDbContext


    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function


    <WebMethod()> _
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Async Function Inscription(email As String, password As String, login As String, idTypeCompte As String, idPays As String) As Threading.Tasks.Task
        Dim RS As String = "["

        Dim user As New ApplicationUser
        user.Email = email
        user.PasswordHash = password
        user.MyPassword = password
        user.DateCreation = Now
        user.UserName = login
        user.StatutExistant = True
        user.TypeCompteId = idTypeCompte
        user.PaysId = idPays
        'c'est la ligne si desous qui cree et enregistre enregistre.
        Dim result = Await UserManager.CreateAsync(user, password)
        If result.Succeeded Then
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
        Else
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "echec enregistrement utlisateur" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
        End If
    End Function

    <WebMethod()> _
 <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub Login(username As String, pwd As String)
        Dim RS As String = "["
        'Dim appUser = Await UserManager.FindAsync(username, pwd)
        Dim PasswordHash = UserManager.PasswordHasher.HashPassword(pwd)
        Dim user = (From u In db.Users Where u.UserName = username And u.MyPassword = pwd Select u).ToList
        If Not user.Count = 0 Then
            Dim id = user.First.Id
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & id & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
        Else
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & " informations incorrectes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
        End If
    End Sub

    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddJob(titre As String, desccription As String, budgetMin As String, budgetMax As Double)
        Dim RS As String = "["

        Dim job As New Jobs
        job.Titre = titre
        job.Description = desccription
        job.DateCreation = Now
        job.DatePublication = Now
        job.BudgetMinimal = budgetMin
        job.BudgetMaximal = budgetMax
        job.BudgetAttribution = 0
        job.Code = ""
        job.LieuExecution = ""
        job.DatePrevueLivraison = Now
        job.DateAttribution = Now
        job.DateCloture = Now
        job.CahierDeCharge = {0}
        job.UserPublierId = ""
        job.UserAttribuerId = ""
        job.TypeJobId = 1
        job.StatutId = 1
        job.Code = ""
        job.SousSecteurActiviteId = 1
        job.StatutExistant = True



        db.Jobs.Add(job)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de créer ce Job" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub


    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddTypeJob(libelle As String)
        Dim RS As String = "["

        Dim typeJob As New TypeJob
        typeJob.Libelle = libelle
        typeJob.DateCreation = Now
        typeJob.StatutExistant = True

        db.TypeJob.Add(typeJob)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de créer ce type de job" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub

    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddStatusJob(libelle As String)
        Dim RS As String = "["

        Dim statut As New Statut
        statut.Libelle = libelle
        statut.DateCreation = Now
        statut.StatutExistant = True

        db.Statuts.Add(statut)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de créer ce statut" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub


    <WebMethod()> _
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub ModifierUser(login As String, email As String, nom As String, prenom As String, sexe As String, telephone As String)
        Dim RS As String = "["

        'ApplicationUser user = db.Users.Single()

        Dim user As New ApplicationUser
        user.Nom = nom
        user.Prenom = prenom
        user.Sexe = sexe
        user.Email = email
        user.Telephone = telephone
        'user.Cni = ""
        'user.Fonction = ""
        'user.Entreprise = ""
        'user.Photo = {0}
        'user.PaysId = 0
        'user.TypeCompteId = 0
        'user.NumeroCompte = ""
        'user.UserName = nom
        'user.PasswordHash = ""
        'user.SecurityStamp = ""
        'user.DateNaissance = Now
        'user.SiteWeb = ""
        'user.DateCreation = Now
        'user.StatutExistant = True

        db.Users.Add(user)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de créer cette personne" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub

    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddPays(nom As String, abreviation As String, identifiantTel As String)
        Dim RS As String = "["

        Dim pays As New Pays
        pays.Nom = nom
        pays.Abreviation = abreviation
        pays.DateCreation = Now
        pays.IdentifiantTelephonique = identifiantTel
        pays.StatutExistant = True

        db.Pays.Add(pays)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de créer ce pays" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub

    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub ModifierPays(idpays As Long, nom As String, abreviation As String, identifiantTel As String)
        Dim RS As String = "["

        'Dim pays As New Pays
        Dim pay = (From u In db.Pays Where u.Id = 1 Select u)
        pay.First.Nom = nom
        pay.First.Abreviation = abreviation
        pay.First.IdentifiantTelephonique = identifiantTel
        db.Pays.Add(pay)


        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de créer ce pays" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub


    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddTypeCompte(libelle As String)
        Dim RS As String = "["

        Dim typeCompte As New TypeCompte
        typeCompte.Libelle = libelle
        typeCompte.DateCreation = Now
        typeCompte.StatutExistant = True

        db.TypeCompte.Add(typeCompte)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de créer ce Compte" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub

    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddCertification(libelle As String, description As String)
        Dim RS As String = "["

        Dim Certification As New Certification
        Certification.CvId = Nothing
        Certification.Libelle = libelle
        Certification.Description = description
        Certification.DateObtention = Now
        Certification.DateCreation = Now
        Certification.StatutExistant = True

        db.Certification.Add(Certification)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de ajouter cette certification" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub

    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddReference(titre As String, description As String, adresse As String)
        Dim RS As String = "["

        Dim reference As New Reference
        reference.Annee = Now
        reference.Titre = titre
        reference.Description = description
        reference.Adresse = adresse
        reference.DateCreation = Now
        reference.StatutExistant = True

        db.Reference.Add(reference)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de ajouter cette reference" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub


    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddCursus(poste As String, titre As String, periode As String, struture As String, diplome As String)
        Dim RS As String = "["

        Dim curcus As New Cursus
        curcus.Structures = struture
        curcus.Poste = poste
        curcus.Periode = periode
        curcus.Titre = titre
        curcus.Diplome = diplome
        curcus.DateCreation = Now
        curcus.StatutExistant = True

        db.Cursus.Add(curcus)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de ajouter cette reference" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub

    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddSecteurActivite(libelle As String, description As String)
        Dim RS As String = "["

        Dim Secteur As New SecteurActivite
        Secteur.Libelle = libelle
        Secteur.Description = description
        Secteur.DateCreation = Now
        Secteur.StatutExistant = True

        db.SecteurActivite.Add(Secteur)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de ajouter ce sous secteur activite" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub


    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub AddSousSecteurActivite(libelle As String, description As String, code As String, idSecteur As Long)
        Dim RS As String = "["

        Dim sousSecteur As New SousSecteurActivite
        sousSecteur.Libelle = libelle
        sousSecteur.Description = description
        sousSecteur.Code = code
        sousSecteur.SecteurActiviteId = idSecteur
        sousSecteur.DateCreation = Now
        sousSecteur.StatutExistant = True

        db.SousSecteurActivite.Add(sousSecteur)
        Try
            db.SaveChanges()
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Enregistrement effectuer avec succes" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            'Return Jsonc(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        Catch ex As Exception
            RS += "{" & Chr(34) & "Success" & Chr(34) & ":" & Chr(34) & "0" & Chr(34) & "," & Chr(34) & "exc" & Chr(34) & ":" & Chr(34) & "Impossible de ajouter ce sous secteur activite" & Chr(34) & "}"
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
            ' Return Json(New With {Key .Success = 0, Key .ex = New Exception("Impossible de créer cette Commande").Message.ToString()})
        End Try
    End Sub

    'fonction pour la selection des données en BD
    '
    '
    '

    <WebMethod()> _
    <ScriptMethod(UseHttpGet:=True, ResponseFormat:=ResponseFormat.Json)> _
    Public Sub ListePays()
        Try
            Dim entities = (From e In db.Pays.OfType(Of Pays)() Select e)

            Dim sb As New StringBuilder()
            Dim RS As String = "["

            For Each item In entities
                RS += "{" & Chr(34) & "id" & Chr(34) & ":" & Chr(34) & item.Id.ToString & Chr(34) & "," & Chr(34) & "Nom" & Chr(34) & ":" & Chr(34) & item.Nom.ToString.TrimEnd & Chr(34) & "," & Chr(34) & "abreviation" & Chr(34) & ":" & Chr(34) & item.Abreviation.ToString.TrimEnd & Chr(34) & "," & Chr(34) & "identifiant telephonique" & Chr(34) & ":" & Chr(34) & item.IdentifiantTelephonique.ToString.TrimEnd & Chr(34) & "},"
            Next
            RS = RS.Remove(RS.Length - 1, 1)
            RS += "]"
            RS = Replace(RS, "", vbNullString)
            Context.Response.Write(RS)
        Catch ex As Exception
            Context.Response.Write(String.Format("[ERROR: {0}]", ex.Message))
        End Try
    End Sub

    '<WebMethod()> _
    '<ScriptMethod(UseHttpGet:=True, ResponseFormat:=ResponseFormat.Json)> _
    'Public Sub ListePays()
    '    Try
    '        Dim entities = (From e In db.AspNetUsers.OfType(Of AspNetUsers)() Select e)

    '        Dim sb As New StringBuilder()
    '        Dim RS As String = "["

    '        For Each item In entities
    '            RS += "{" & Chr(34) & "id" & Chr(34) & ":" & Chr(34) & item.Id.ToString & Chr(34) & "," & Chr(34) & "Nom" & Chr(34) & ":" & Chr(34) & item.Nom.ToString.TrimEnd & Chr(34) & "," & Chr(34) & "abreviation" & Chr(34) & ":" & Chr(34) & item.Abreviation.ToString.TrimEnd & Chr(34) & "," & Chr(34) & "identifiant telephonique" & Chr(34) & ":" & Chr(34) & item.IdentifiantTelephonique.ToString.TrimEnd & Chr(34) & "},"
    '        Next
    '        RS = RS.Remove(RS.Length - 1, 1)
    '        RS += "]"
    '        RS = Replace(RS, "", vbNullString)
    '        Context.Response.Write(RS)
    '    Catch ex As Exception
    '        Context.Response.Write(String.Format("[ERROR: {0}]", ex.Message))
    '    End Try
    'End Sub

    Private Function RecuperUsers() As ApplicationUser
        Dim id = User.Identity.GetUserId
        Dim aspuser = db.Users.Find(id)
        Return aspuser
    End Function

End Class