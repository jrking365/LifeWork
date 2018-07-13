Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class TypeCompteController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /TypeCompte/
        Function Index() As ActionResult
            Return View(db.TypeCompte.ToList())
        End Function

        ' GET: /TypeCompte/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim typecompte As TypeCompte = db.TypeCompte.Find(id)
            If IsNothing(typecompte) Then
                Return HttpNotFound()
            End If
            Return View(typecompte)
        End Function

        ' GET: /TypeCompte/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /TypeCompte/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,Libelle,StatutExistant,DateCreation")> ByVal typecompte As TypeCompte) As ActionResult
            If ModelState.IsValid Then
                db.TypeCompte.Add(typecompte)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(typecompte)
        End Function

        ' GET: /TypeCompte/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim typecompte As TypeCompte = db.TypeCompte.Find(id)
            If IsNothing(typecompte) Then
                Return HttpNotFound()
            End If
            Return View(typecompte)
        End Function

        ' POST: /TypeCompte/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,Libelle,StatutExistant,DateCreation")> ByVal typecompte As TypeCompte) As ActionResult
            If ModelState.IsValid Then
                db.Entry(typecompte).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(typecompte)
        End Function

        ' GET: /TypeCompte/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim typecompte As TypeCompte = db.TypeCompte.Find(id)
            If IsNothing(typecompte) Then
                Return HttpNotFound()
            End If
            Return View(typecompte)
        End Function

        ' POST: /TypeCompte/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim typecompte As TypeCompte = db.TypeCompte.Find(id)
            db.TypeCompte.Remove(typecompte)
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
