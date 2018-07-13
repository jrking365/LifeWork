Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class StatutController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Statut/
        Function Index() As ActionResult
            Return View(db.Statuts.ToList())
        End Function

        ' GET: /Statut/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim statut As Statut = db.Statuts.Find(id)
            If IsNothing(statut) Then
                Return HttpNotFound()
            End If
            Return View(statut)
        End Function

        ' GET: /Statut/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Statut/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,Libelle,StatutExistant,DateCreation")> ByVal statut As Statut) As ActionResult
            If ModelState.IsValid Then
                db.Statuts.Add(statut)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(statut)
        End Function

        ' GET: /Statut/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim statut As Statut = db.Statuts.Find(id)
            If IsNothing(statut) Then
                Return HttpNotFound()
            End If
            Return View(statut)
        End Function

        ' POST: /Statut/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,Libelle,StatutExistant,DateCreation")> ByVal statut As Statut) As ActionResult
            If ModelState.IsValid Then
                db.Entry(statut).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(statut)
        End Function

        ' GET: /Statut/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim statut As Statut = db.Statuts.Find(id)
            If IsNothing(statut) Then
                Return HttpNotFound()
            End If
            Return View(statut)
        End Function

        ' POST: /Statut/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim statut As Statut = db.Statuts.Find(id)
            db.Statuts.Remove(statut)
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
