Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class CompteBancaireController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /CompteBancaire/
        Function Index() As ActionResult
            Dim comptebancaire = db.CompteBancaire.Include(Function(c) c.User)
            Return View(comptebancaire.ToList())
        End Function

        ' GET: /CompteBancaire/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim comptebancaire As CompteBancaire = db.CompteBancaire.Find(id)
            If IsNothing(comptebancaire) Then
                Return HttpNotFound()
            End If
            Return View(comptebancaire)
        End Function

        ' GET: /CompteBancaire/Create
        Function Create() As ActionResult
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

        ' POST: /CompteBancaire/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,UserId,Code,DatePeremption,Solde,StatutExistant,DateCreation")> ByVal comptebancaire As CompteBancaire) As ActionResult
            If ModelState.IsValid Then
                db.CompteBancaire.Add(comptebancaire)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", comptebancaire.UserId)
            Return View(comptebancaire)
        End Function

        ' GET: /CompteBancaire/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim comptebancaire As CompteBancaire = db.CompteBancaire.Find(id)
            If IsNothing(comptebancaire) Then
                Return HttpNotFound()
            End If
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", comptebancaire.UserId)
            Return View(comptebancaire)
        End Function

        ' POST: /CompteBancaire/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,UserId,Code,DatePeremption,Solde,StatutExistant,DateCreation")> ByVal comptebancaire As CompteBancaire) As ActionResult
            If ModelState.IsValid Then
                db.Entry(comptebancaire).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", comptebancaire.UserId)
            Return View(comptebancaire)
        End Function

        ' GET: /CompteBancaire/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim comptebancaire As CompteBancaire = db.CompteBancaire.Find(id)
            If IsNothing(comptebancaire) Then
                Return HttpNotFound()
            End If
            Return View(comptebancaire)
        End Function

        ' POST: /CompteBancaire/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim comptebancaire As CompteBancaire = db.CompteBancaire.Find(id)
            db.CompteBancaire.Remove(comptebancaire)
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
