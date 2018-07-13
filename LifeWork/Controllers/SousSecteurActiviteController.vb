Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class SousSecteurActiviteController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /SousSecteurActivite/
        Function Index() As ActionResult
            Dim soussecteuractivite = db.SousSecteurActivite.Include(Function(s) s.SecteurActivite)
            Return View(soussecteuractivite.ToList())
        End Function

        ' GET: /SousSecteurActivite/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim soussecteuractivite As SousSecteurActivite = db.SousSecteurActivite.Find(id)
            If IsNothing(soussecteuractivite) Then
                Return HttpNotFound()
            End If
            Return View(soussecteuractivite)
        End Function

        ' GET: /SousSecteurActivite/Create
        Function Create() As ActionResult
            ViewBag.SecteurActiviteId = New SelectList(db.SecteurActivite, "Id", "Libelle")
            Return View()
        End Function

        ' POST: /SousSecteurActivite/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,SecteurActiviteId,Libelle,Description,Code,StatutExistant,DateCreation")> ByVal soussecteuractivite As SousSecteurActivite) As ActionResult
            If ModelState.IsValid Then
                db.SousSecteurActivite.Add(soussecteuractivite)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.SecteurActiviteId = New SelectList(db.SecteurActivite, "Id", "Libelle", soussecteuractivite.SecteurActiviteId)
            Return View(soussecteuractivite)
        End Function

        ' GET: /SousSecteurActivite/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim soussecteuractivite As SousSecteurActivite = db.SousSecteurActivite.Find(id)
            If IsNothing(soussecteuractivite) Then
                Return HttpNotFound()
            End If
            ViewBag.SecteurActiviteId = New SelectList(db.SecteurActivite, "Id", "Libelle", soussecteuractivite.SecteurActiviteId)
            Return View(soussecteuractivite)
        End Function

        ' POST: /SousSecteurActivite/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,SecteurActiviteId,Libelle,Description,Code,StatutExistant,DateCreation")> ByVal soussecteuractivite As SousSecteurActivite) As ActionResult
            If ModelState.IsValid Then
                db.Entry(soussecteuractivite).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.SecteurActiviteId = New SelectList(db.SecteurActivite, "Id", "Libelle", soussecteuractivite.SecteurActiviteId)
            Return View(soussecteuractivite)
        End Function

        ' GET: /SousSecteurActivite/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim soussecteuractivite As SousSecteurActivite = db.SousSecteurActivite.Find(id)
            If IsNothing(soussecteuractivite) Then
                Return HttpNotFound()
            End If
            Return View(soussecteuractivite)
        End Function

        ' POST: /SousSecteurActivite/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim soussecteuractivite As SousSecteurActivite = db.SousSecteurActivite.Find(id)
            db.SousSecteurActivite.Remove(soussecteuractivite)
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
