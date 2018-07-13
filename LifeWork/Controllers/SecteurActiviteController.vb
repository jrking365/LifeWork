Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class SecteurActiviteController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /SecteurActivite/
        Function Index() As ActionResult
            Return View(db.SecteurActivite.ToList())
        End Function

        ' GET: /SecteurActivite/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim secteuractivite As SecteurActivite = db.SecteurActivite.Find(id)
            If IsNothing(secteuractivite) Then
                Return HttpNotFound()
            End If
            Return View(secteuractivite)
        End Function

        ' GET: /SecteurActivite/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /SecteurActivite/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,Libelle,Description,StatutExistant,DateCreation")> ByVal secteuractivite As SecteurActivite) As ActionResult
            If ModelState.IsValid Then
                db.SecteurActivite.Add(secteuractivite)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(secteuractivite)
        End Function

        ' GET: /SecteurActivite/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim secteuractivite As SecteurActivite = db.SecteurActivite.Find(id)
            If IsNothing(secteuractivite) Then
                Return HttpNotFound()
            End If
            Return View(secteuractivite)
        End Function

        ' POST: /SecteurActivite/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,Libelle,Description,StatutExistant,DateCreation")> ByVal secteuractivite As SecteurActivite) As ActionResult
            If ModelState.IsValid Then
                db.Entry(secteuractivite).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(secteuractivite)
        End Function

        ' GET: /SecteurActivite/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim secteuractivite As SecteurActivite = db.SecteurActivite.Find(id)
            If IsNothing(secteuractivite) Then
                Return HttpNotFound()
            End If
            Return View(secteuractivite)
        End Function

        ' POST: /SecteurActivite/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim secteuractivite As SecteurActivite = db.SecteurActivite.Find(id)
            db.SecteurActivite.Remove(secteuractivite)
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
