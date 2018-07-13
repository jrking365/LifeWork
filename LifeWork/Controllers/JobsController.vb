Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity

Namespace LifeWork
    Public Class JobsController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext


        ''' <summary>
        ''' DEBUT FONCTION TRAITEMENT IMAGE
        ''' </summary>
        ''' <param name="Id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ShowImage(Id As String) As ActionResult
            If IsNothing(Id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim user As ApplicationUser = db.Users.Find(Id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            Return File(user.Photo, "image/png")
        End Function
        '' FIN FONCTION TRAITEMENT IMAGE

        ' GET: /Jobs/
        Function Index() As ActionResult
            Dim id_User = GetUserConnected.Id
            'Dim jobs = db.Jobs.Include(Function(j) j.SousSecteurActivite).Include(Function(j) j.statut).Include(Function(j) j.TypeJob).Include(Function(j) j.UserAttribuer).Include(Function(j) j.UserPublier)
            Dim jobs = From j In db.Jobs.OfType(Of Jobs)() Where (j.StatutExistant = True) Select j
            'Dim entities = (From e In db.Article.OfType(Of Article)() Select e)
            ViewBag.idUse = GetUserConnected.Id
            Return View(jobs.ToList())
        End Function

        ''' <summary>
        ''' Jobs disponible pour freelancer
        ''' </summary>
        ''' <returns></returns>
        Function jobsDispo() As ActionResult
            Dim id_user = GetUserConnected.Id
            Dim jobs = From j In db.Jobs.OfType(Of Jobs)() Join us In db.UserSousSecteur.OfType(Of UserSousSecteurActivite)() On j.SousSecteurActiviteId Equals us.SousSecteurActiviteId Where (j.StatutExistant = True) AndAlso
                                                                                                                                                                                             (us.UserId = id_user) AndAlso (j.UserPublierId <> id_user) AndAlso (j.StatutId = 2) Select j
            ViewBag.idUse = GetUserConnected.Id
            Return View(jobs.ToList())
        End Function

        ''' <summary>
        ''' affiche les jobs terminé pour l'employeur
        ''' </summary>
        ''' <returns></returns>
        Function JobsClotureEmployeur() As ActionResult
            Dim id_user = GetUserConnected.Id
            Dim jobs = From j In db.Jobs.OfType(Of Jobs)() Join s In db.Statuts.OfType(Of Statut)() On j.StatutId Equals s.Id
                       Where (s.Libelle = "Cloture") AndAlso (j.UserPublierId = id_user) Select j
            Return View(jobs.ToList())
        End Function


        ''' <summary>
        ''' affiche les jobs terminé pour le prestataire
        ''' </summary>
        ''' <returns></returns>
        Function JobsCloturePrestataire() As ActionResult
            Dim id_user = GetUserConnected.Id
            Dim jobs = From j In db.Jobs.OfType(Of Jobs)() Join s In db.Statuts.OfType(Of Statut)() On j.StatutId Equals s.Id
                       Where (s.Libelle = "Cloture") AndAlso (j.UserAttribuerId = id_user) Select j
            Return View(jobs.ToList())
        End Function

        'GET/ /Jobs en cours/
        ''' <summary>
        ''' FONCTION QUI RETOURNE LES JOBS DE L'UTILISATEUR QUI SONT EN COURS
        ''' </summary>
        ''' <returns>retourne les jobs de l'utilisateur en ligne</returns>
        Function JobEnCours() As ActionResult
            Dim id_User = GetUserConnected.Id
            Dim jobs = From j In db.Jobs.OfType(Of Jobs)() Join s In db.Statuts.OfType(Of Statut)() On j.StatutId Equals s.Id
                       Where (s.Libelle = "En cours" Or s.Libelle = "Execute") AndAlso (j.UserPublierId = id_User) Select j

            Return View(jobs.ToList())
        End Function
        '' FIN FONCTION QUI RETOURNE LES JOBS DE L'UTILISATEUR QUI SONT EN COURS

        ''' <summary>
        ''' retourne la liste des jobs en cours chez le prestataire
        ''' </summary>
        ''' <returns></returns>
        Function JobEnCoursPrestataire() As ActionResult
            Dim id_user = GetUserConnected.Id
            Dim jobs = From j In db.Jobs.OfType(Of Jobs)() Join s In db.Statuts.OfType(Of Statut)() On j.StatutId Equals s.Id
                       Where (s.Libelle = "En cours") AndAlso (j.UserAttribuerId = id_user) Select j
            Return View(jobs.ToList())
        End Function

        ''' <summary>
        ''' retourne la liste des jobs posté auxquel on peux encore postuler
        ''' </summary>
        ''' <returns>retourne les jobs qui n'ont pas encore été attribué</returns>
        Function JobOuvertPostulation() As ActionResult
            Dim id_User = GetUserConnected.Id
            Dim jobs = From j In db.Jobs.OfType(Of Jobs)() Where (j.StatutExistant = True) AndAlso (j.UserPublierId = id_User) AndAlso (j.UserAttribuerId Is Nothing) Select j
            Return View(jobs.ToList())
        End Function
        ''Fin Fonction qui retourne la liste des jobs posté auxquel on peux encore postuler

        ''' <summary>
        ''' DEBUT FONCTION QUI RETOURNE L'UTILISATEUR CONNECTE ACTUELLEMENT
        ''' </summary>
        ''' <returns>userConnected</returns>
        ''' <remarks></remarks>
        Public Function GetUserConnected() As ApplicationUser
            Dim id = User.Identity.GetUserId
            Dim userConnected = db.Users.Find(id)
            Return userConnected
        End Function
        '' FIN FONCTION QUI RETOURNE L'UTILISATEUR CONNECTE ACTUELLEMENT

        ''' <summary>
        ''' FONCTION QUI RETOURNE LES INFORMATION DE L'EMPLOYEUR EN FONCTION DU JOBID
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>Employeur</returns>
        Public Function GetInfosEmployeurByJobsId(ByVal id As Long?) As ApplicationUser
            Dim Employeur = From E In db.Users.OfType(Of ApplicationUser)() Join J In db.Jobs.OfType(Of Jobs)() On E.Id Equals J.UserPublierId
                            Where (J.Id = id) & (J.StatutExistant = True) Select E
            Return Employeur
        End Function
        ''FIN FONCTION QUI RETOURNE LES INFORMATION DE L'EMPLOYEUR EN FONCTION DU JOBID

        'GET MarquerExecute
        Public Function MarquerExecute(ByVal idJob As Long?) As ActionResult

            If IsNothing(idJob) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim job As Jobs = db.Jobs.Find(idJob)
            If IsNothing(job) Then
                Return HttpNotFound()
            End If

            job.StatutId = 4
            SendSmsLMTG("237", job.UserPublier.Telephone.ToString, "Votre Job a ete marque execute par votre prestataire bien vouloir vous connecter")
            db.Entry(job).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("JobEnCoursPrestataire")

        End Function

        ''' <summary>
        ''' pour cloturer un job
        ''' </summary>
        ''' <param name="idJob"></param>
        ''' <returns></returns>
        Public Function MarquerExecuteEmployeur(ByVal idJob As Long?) As ActionResult
            If IsNothing(idJob) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim job As Jobs = db.Jobs.Find(idJob)
            If IsNothing(job) Then
                Return HttpNotFound()
            End If
            job.StatutId = 3
            SendSmsLMTG("237", job.UserAttribuer.Telephone.ToString, "le Job que vous avez execute a ete cloture  par votre employeur bien vouloir vous connecter")
            db.Entry(job).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("JobEnCours")
        End Function

        '<HttpPost()>
        '<ActionName("MarquerExecute")>
        'Public Function MarquerExecute(ByVal Job As Jobs) As ActionResult
        '    Job.StatutId = 4
        '    db.Entry(Job).State = EntityState.Modified
        '    db.SaveChanges()
        '    Return RedirectToAction("JobEnCoursPrestataire")

        'End Function

        ''' <summary>
        ''' Fonction qui va renvoyer vers la page d'attribution
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function PageAttribuer(ByVal id As String, ByVal jobsid As Long?) As ActionResult
            Dim postulation = (From P In db.Postuler.OfType(Of PostulerJob)() Where P.UserId = id AndAlso P.JobsId = jobsid Select P.BudgetExige).Sum()
            Dim job As Jobs = db.Jobs.Find(jobsid)
            ViewBag.BudgetExige = Convert.ToDouble(postulation)
            ViewBag.user = GetUserConnected()

            Return View(job)

        End Function

        <HttpPost()>
        <ActionName("PageAttribuer")>
        <ValidateAntiForgeryToken()>
        Public Function PageAttribuerConfirmed(ByVal id As String, ByVal jobsid As Long?) As ActionResult
            Dim job As Jobs = db.Jobs.Find(jobsid)
            job.UserAttribuerId = id
            Dim Budgetexig = (From P In db.Postuler.OfType(Of PostulerJob)() Where P.UserId = id AndAlso P.JobsId = jobsid Select P.BudgetExige).Single()
            job.BudgetAttribution = Convert.ToDouble(Budgetexig)
            db.Entry(job).State = EntityState.Modified
            db.SaveChanges()
            SendSmsLMTG("237", job.UserAttribuer.Telephone.ToString, "Un job vous a ete attribue bien vouloir vous connecter")
            Return RedirectToAction("JobOuvertPostulation")
        End Function



        ' GET: /Jobs/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim jobs As Jobs = db.Jobs.Find(id)
            Dim postuleurs = From p In db.Postuler.OfType(Of PostulerJob)() Where p.JobsId = id Select p 'recupérer la liste des personnes qui ont postulé 
            If IsNothing(jobs) Then
                Return HttpNotFound()
            End If
            ViewBag.Postuleurs = postuleurs.ToList()
            ViewBag.idUse = GetUserConnected.Id
            ViewBag.TypeCompteUser = GetUserConnected().TypeCompte.Libelle
            Return View(jobs)
        End Function



        ' GET: /Jobs/Create
        Function Create() As ActionResult
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle")
            ViewBag.StatutId = New SelectList(db.Statuts, "Id", "Libelle")
            ViewBag.TypeJobId = New SelectList(db.TypeJob, "Id", "Libelle")
            ViewBag.idUser = GetUserConnected().Id
            ViewBag.TypeCompteUser = GetUserConnected().TypeCompte.Libelle

            'ViewBag.UserAttribuerId = New SelectList(db.IdentityUsers, "Id", "UserName")
            'ViewBag.UserPublierId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

        ' POST: /Jobs/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,UserPublierId,UserAttribuerId,TypeJobId,SousSecteurActiviteId,StatutId,Titre,Duree,Code,Description,LieuExecution,DatePrevueLivraison,DatePublication,DateAttribution,DateCloture,BudgetMinimal,BudgetMaximal,BudgetAttribution,CahierDeCharge,StatutExistant,DateCreation")> ByVal jobs As Jobs) As ActionResult
            jobs.StatutExistant = True
            jobs.DateCreation = Now
            jobs.UserPublierId = GetUserConnected.Id
            jobs.StatutId = 2
            If ModelState.IsValid Then
                db.Jobs.Add(jobs)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle", jobs.SousSecteurActiviteId)
            ViewBag.StatutId = New SelectList(db.Statuts, "Id", "Libelle", jobs.StatutId)
            ViewBag.TypeJobId = New SelectList(db.TypeJob, "Id", "Libelle", jobs.TypeJobId)
            'ViewBag.UserAttribuerId = New SelectList(db.IdentityUsers, "Id", "UserName", jobs.UserAttribuerId)
            'ViewBag.UserPublierId = New SelectList(db.IdentityUsers, "Id", "UserName", jobs.UserPublierId)
            Return View(jobs)
        End Function

        ' GET: /Jobs/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim jobs As Jobs = db.Jobs.Find(id)
            If IsNothing(jobs) Then
                Return HttpNotFound()
            End If
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle", jobs.SousSecteurActiviteId)
            ViewBag.StatutId = New SelectList(db.Statuts, "Id", "Libelle", jobs.StatutId)
            ViewBag.TypeJobId = New SelectList(db.TypeJob, "Id", "Libelle", jobs.TypeJobId)
            'ViewBag.UserAttribuerId = New SelectList(db.IdentityUsers, "Id", "UserName", jobs.UserAttribuerId)
            'ViewBag.UserPublierId = New SelectList(db.IdentityUsers, "Id", "UserName", jobs.UserPublierId)
            Return View(jobs)
        End Function

        ' POST: /Jobs/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,UserPublierId,UserAttribuerId,TypeJobId,SousSecteurActiviteId,StatutId,Titre,Duree,Code,Description,LieuExecution,DatePrevueLivraison,DatePublication,DateAttribution,DateCloture,BudgetMinimal,BudgetMaximal,BudgetAttribution,CahierDeCharge,StatutExistant,DateCreation")> ByVal jobs As Jobs) As ActionResult
            If ModelState.IsValid Then
                db.Entry(jobs).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle", jobs.SousSecteurActiviteId)
            ViewBag.StatutId = New SelectList(db.Statuts, "Id", "Libelle", jobs.StatutId)
            ViewBag.TypeJobId = New SelectList(db.TypeJob, "Id", "Libelle", jobs.TypeJobId)
            'ViewBag.UserAttribuerId = New SelectList(db.IdentityUsers, "Id", "UserName", jobs.UserAttribuerId)
            'ViewBag.UserPublierId = New SelectList(db.IdentityUsers, "Id", "UserName", jobs.UserPublierId)
            Return View(jobs)
        End Function

        ' GET: /Jobs/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim jobs As Jobs = db.Jobs.Find(id)
            If IsNothing(jobs) Then
                Return HttpNotFound()
            End If
            Return View(jobs)
        End Function

        ' POST: /Jobs/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim jobs As Jobs = db.Jobs.Find(id)
            db.Jobs.Remove(jobs)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
