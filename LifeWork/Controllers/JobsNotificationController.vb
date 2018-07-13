Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class JobsNotificationController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /JobsNotification/
        Function Index() As ActionResult
            Dim jobsnotification = db.JobsNotification.Include(Function(j) j.Jobs).Include(Function(j) j.Notification)
            Return View(jobsnotification.ToList())
        End Function

        ' GET: /JobsNotification/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim jobsnotification As JobsNotification = db.JobsNotification.Find(id)
            If IsNothing(jobsnotification) Then
                Return HttpNotFound()
            End If
            Return View(jobsnotification)
        End Function

        ' GET: /JobsNotification/Create
        Function Create() As ActionResult
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId")
            ViewBag.NotificationId = New SelectList(db.Notification, "Id", "Titre")
            Return View()
        End Function

        ' POST: /JobsNotification/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "JobsId,NotificationId,StatutExistant,DateCreation")> ByVal jobsnotification As JobsNotification) As ActionResult
            If ModelState.IsValid Then
                db.JobsNotification.Add(jobsnotification)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", jobsnotification.JobsId)
            ViewBag.NotificationId = New SelectList(db.Notification, "Id", "Titre", jobsnotification.NotificationId)
            Return View(jobsnotification)
        End Function

        ' GET: /JobsNotification/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim jobsnotification As JobsNotification = db.JobsNotification.Find(id)
            If IsNothing(jobsnotification) Then
                Return HttpNotFound()
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", jobsnotification.JobsId)
            ViewBag.NotificationId = New SelectList(db.Notification, "Id", "Titre", jobsnotification.NotificationId)
            Return View(jobsnotification)
        End Function

        ' POST: /JobsNotification/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "JobsId,NotificationId,StatutExistant,DateCreation")> ByVal jobsnotification As JobsNotification) As ActionResult
            If ModelState.IsValid Then
                db.Entry(jobsnotification).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", jobsnotification.JobsId)
            ViewBag.NotificationId = New SelectList(db.Notification, "Id", "Titre", jobsnotification.NotificationId)
            Return View(jobsnotification)
        End Function

        ' GET: /JobsNotification/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim jobsnotification As JobsNotification = db.JobsNotification.Find(id)
            If IsNothing(jobsnotification) Then
                Return HttpNotFound()
            End If
            Return View(jobsnotification)
        End Function

        ' POST: /JobsNotification/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim jobsnotification As JobsNotification = db.JobsNotification.Find(id)
            db.JobsNotification.Remove(jobsnotification)
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
