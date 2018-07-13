Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class TypeMessagerieController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /TypeMessagerie/
        Function Index() As ActionResult
            Return View(db.TypeMessagerie.ToList())
        End Function

        ' GET: /TypeMessagerie/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim typemessagerie As TypeMessagerie = db.TypeMessagerie.Find(id)
            If IsNothing(typemessagerie) Then
                Return HttpNotFound()
            End If
            Return View(typemessagerie)
        End Function

        ' GET: /TypeMessagerie/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /TypeMessagerie/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,Titre,StatutExistant,DateCreation")> ByVal typemessagerie As TypeMessagerie) As ActionResult
            If ModelState.IsValid Then
                db.TypeMessagerie.Add(typemessagerie)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(typemessagerie)
        End Function

        ' GET: /TypeMessagerie/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim typemessagerie As TypeMessagerie = db.TypeMessagerie.Find(id)
            If IsNothing(typemessagerie) Then
                Return HttpNotFound()
            End If
            Return View(typemessagerie)
        End Function

        ' POST: /TypeMessagerie/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,Titre,StatutExistant,DateCreation")> ByVal typemessagerie As TypeMessagerie) As ActionResult
            If ModelState.IsValid Then
                db.Entry(typemessagerie).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(typemessagerie)
        End Function

        ' GET: /TypeMessagerie/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim typemessagerie As TypeMessagerie = db.TypeMessagerie.Find(id)
            If IsNothing(typemessagerie) Then
                Return HttpNotFound()
            End If
            Return View(typemessagerie)
        End Function

        ' POST: /TypeMessagerie/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim typemessagerie As TypeMessagerie = db.TypeMessagerie.Find(id)
            db.TypeMessagerie.Remove(typemessagerie)
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
