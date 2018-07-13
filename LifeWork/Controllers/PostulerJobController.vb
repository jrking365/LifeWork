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
    Public Class PostulerJobController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /PostulerJob/
        Function Index() As ActionResult
            Dim postuler = db.Postuler.Include(Function(p) p.Job).Include(Function(p) p.User)
            Return View(postuler.ToList())
        End Function




        ' GET: /PostulerJob/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim postulerjob As PostulerJob = db.Postuler.Find(id)
            If IsNothing(postulerjob) Then
                Return HttpNotFound()
            End If
            Return View(postulerjob)
        End Function

        ' GET: /PostulerJob/Create
        Function Create() As ActionResult
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId")
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

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

        ' POST: /PostulerJob/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="UserId,JobsId,Description,DureeExecution,BudgetExige,DateEnvoi,StatutExistant,DateCreation")> ByVal postulerjob As PostulerJob) As ActionResult
            postulerjob.StatutExistant = True
            postulerjob.UserId = GetUserConnected.Id
            postulerjob.DateCreation = Now
            postulerjob.DateEnvoi = Now
            If ModelState.IsValid Then
                db.Postuler.Add(postulerjob)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", postulerjob.JobsId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", postulerjob.UserId)
            Return View(postulerjob)
        End Function



        Public Shared leid As Long
        ''' <summary>
        ''' Fonction pour le modale qui affiche la vue
        ''' </summary>
        ''' <returns></returns>
        <HttpGet>
        Public Function vuePostulerA1Job(ByVal id As Long) As ActionResult
            leid = id
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim job As Jobs = db.Jobs.Find(id)
            If IsNothing(job) Then
                Return HttpNotFound()
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", job.Id)
            'Return PartialView("PostulerAJob")
            Return PartialView("PostulerAjob")
        End Function


        ''GET : /PostulerJob/PostulerA1Job/5
        'Public Function PostulerA1Job(ByVal id As String) As ActionResult
        '    If IsNothing(id) Then
        '        Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        '    End If
        '    Dim postulerjob As PostulerJob = db.Postuler.Find(id)
        '    If IsNothing(postulerjob) Then
        '        Return HttpNotFound()
        '    End If
        '    ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", postulerjob.JobsId)
        '    Return View(postulerjob)
        'End Function



        'POST : /PostulerJob/PostulerA1Job/5
        <HttpPost>
        Public Function PostulerA1Job(<Bind(Include:="UserId,JobsId,Description,DureeExecution,BudgetExige,DateEnvoi,StatutExistant,DateCreation")> ByVal postulerjob As PostulerJob) As ActionResult
            postulerjob.JobsId = leid
            Dim job As Jobs = db.Jobs.Find(leid)
            postulerjob.StatutExistant = True
            postulerjob.UserId = GetUserConnected.Id
            postulerjob.DateCreation = Now
            postulerjob.DateEnvoi = Now
            If ModelState.IsValid Then
                SendSmsLMTG("237", job.UserPublier.Telephone.ToString, "Une nouvelle postulation sur un job que vous avez publie, bien vouloir vous connecter")

                db.Postuler.Add(postulerjob)
                db.SaveChanges()
                Return RedirectToAction("Details/" & leid, "Jobs") 'Chercher a renvoyer plutot a la page details du job auquel on vient de postuler
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", postulerjob.JobsId)


            Return View(postulerjob)
        End Function





        ' GET: /PostulerJob/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim postulerjob As PostulerJob = db.Postuler.Find(id)
            If IsNothing(postulerjob) Then
                Return HttpNotFound()
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", postulerjob.JobsId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", postulerjob.UserId)
            Return View(postulerjob)
        End Function

        ' POST: /PostulerJob/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="UserId,JobsId,Description,DureeExecution,BudgetExige,DateEnvoi,StatutExistant,DateCreation")> ByVal postulerjob As PostulerJob) As ActionResult
            If ModelState.IsValid Then
                db.Entry(postulerjob).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", postulerjob.JobsId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", postulerjob.UserId)
            Return View(postulerjob)
        End Function

        ' GET: /PostulerJob/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim postulerjob As PostulerJob = db.Postuler.Find(id)
            If IsNothing(postulerjob) Then
                Return HttpNotFound()
            End If
            Return View(postulerjob)
        End Function

        ' POST: /PostulerJob/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim postulerjob As PostulerJob = db.Postuler.Find(id)
            db.Postuler.Remove(postulerjob)
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
