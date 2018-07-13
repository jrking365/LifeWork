Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class CvController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Cv/
        Function Index() As ActionResult
            Dim cv = db.Cv.Include(Function(c) c.User)
            Return View(cv.ToList())
        End Function

        Function LeCV() As ActionResult

            Return View()
        End Function

        ' GET: /Cv/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cv As Cv = db.Cv.Find(id)
            If IsNothing(cv) Then
                Return HttpNotFound()
            End If
            Return View(cv)
        End Function

        ' GET: /Cv/Create
        Function Create() As ActionResult
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

        ' POST: /Cv/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,UserId,Titre,StatutExistant,DateCreation")> ByVal cv As Cv) As ActionResult
            If ModelState.IsValid Then
                db.Cv.Add(cv)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", cv.UserId)
            Return View(cv)
        End Function

        ' GET: /Cv/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cv As Cv = db.Cv.Find(id)
            If IsNothing(cv) Then
                Return HttpNotFound()
            End If
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", cv.UserId)
            Return View(cv)
        End Function

        ' POST: /Cv/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,UserId,Titre,StatutExistant,DateCreation")> ByVal cv As Cv) As ActionResult
            If ModelState.IsValid Then
                db.Entry(cv).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", cv.UserId)
            Return View(cv)
        End Function

        ' GET: /Cv/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cv As Cv = db.Cv.Find(id)
            If IsNothing(cv) Then
                Return HttpNotFound()
            End If
            Return View(cv)
        End Function

        ' POST: /Cv/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim cv As Cv = db.Cv.Find(id)
            db.Cv.Remove(cv)
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
