Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class NotificationController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Notification/
        Function Index() As ActionResult
            Return View(db.Notification.ToList())
        End Function

        ' GET: /Notification/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim notification As Notification = db.Notification.Find(id)
            If IsNothing(notification) Then
                Return HttpNotFound()
            End If
            Return View(notification)
        End Function

        ' GET: /Notification/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Notification/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,Titre,Contenu,DateEnvoi,StatutExistant,DateCreation")> ByVal notification As Notification) As ActionResult
            If ModelState.IsValid Then
                db.Notification.Add(notification)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(notification)
        End Function

        ' GET: /Notification/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim notification As Notification = db.Notification.Find(id)
            If IsNothing(notification) Then
                Return HttpNotFound()
            End If
            Return View(notification)
        End Function

        ' POST: /Notification/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,Titre,Contenu,DateEnvoi,StatutExistant,DateCreation")> ByVal notification As Notification) As ActionResult
            If ModelState.IsValid Then
                db.Entry(notification).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(notification)
        End Function

        ' GET: /Notification/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim notification As Notification = db.Notification.Find(id)
            If IsNothing(notification) Then
                Return HttpNotFound()
            End If
            Return View(notification)
        End Function

        ' POST: /Notification/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim notification As Notification = db.Notification.Find(id)
            db.Notification.Remove(notification)
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
