Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class UserSousSecteurActiviteController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /UserSousSecteurActivite/
        Function Index() As ActionResult
            Dim usersoussecteur = db.UserSousSecteur.Include(Function(u) u.SousSecteurActivite).Include(Function(u) u.User)
            Return View(usersoussecteur.ToList())
        End Function

        ' GET: /UserSousSecteurActivite/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usersoussecteuractivite As UserSousSecteurActivite = db.UserSousSecteur.Find(id)
            If IsNothing(usersoussecteuractivite) Then
                Return HttpNotFound()
            End If
            Return View(usersoussecteuractivite)
        End Function

        ' GET: /UserSousSecteurActivite/Create
        Function Create() As ActionResult
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle")
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

        ' POST: /UserSousSecteurActivite/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "UserId,SousSecteurActiviteId,StatutExistant,DateCreation")> ByVal usersoussecteuractivite As UserSousSecteurActivite) As ActionResult
            If ModelState.IsValid Then
                db.UserSousSecteur.Add(usersoussecteuractivite)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle", usersoussecteuractivite.SousSecteurActiviteId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", usersoussecteuractivite.UserId)
            Return View(usersoussecteuractivite)
        End Function

        ' GET: /UserSousSecteurActivite/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usersoussecteuractivite As UserSousSecteurActivite = db.UserSousSecteur.Find(id)
            If IsNothing(usersoussecteuractivite) Then
                Return HttpNotFound()
            End If
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle", usersoussecteuractivite.SousSecteurActiviteId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", usersoussecteuractivite.UserId)
            Return View(usersoussecteuractivite)
        End Function

        ' POST: /UserSousSecteurActivite/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "UserId,SousSecteurActiviteId,StatutExistant,DateCreation")> ByVal usersoussecteuractivite As UserSousSecteurActivite) As ActionResult
            If ModelState.IsValid Then
                db.Entry(usersoussecteuractivite).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle", usersoussecteuractivite.SousSecteurActiviteId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", usersoussecteuractivite.UserId)
            Return View(usersoussecteuractivite)
        End Function

        ' GET: /UserSousSecteurActivite/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usersoussecteuractivite As UserSousSecteurActivite = db.UserSousSecteur.Find(id)
            If IsNothing(usersoussecteuractivite) Then
                Return HttpNotFound()
            End If
            Return View(usersoussecteuractivite)
        End Function

        ' POST: /UserSousSecteurActivite/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim usersoussecteuractivite As UserSousSecteurActivite = db.UserSousSecteur.Find(id)
            db.UserSousSecteur.Remove(usersoussecteuractivite)
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
