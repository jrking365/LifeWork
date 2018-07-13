Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class PaysController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Pays/
        Function Index() As ActionResult
            Return View(db.Pays.ToList())
        End Function

        ' GET: /Pays/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pays As Pays = db.Pays.Find(id)
            If IsNothing(pays) Then
                Return HttpNotFound()
            End If
            Return View(pays)
        End Function

        ' GET: /Pays/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Pays/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,Nom,Abreviation,IdentifiantTelephonique,StatutExistant,DateCreation")> ByVal pays As Pays) As ActionResult
            If ModelState.IsValid Then
                db.Pays.Add(pays)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(pays)
        End Function

        ' GET: /Pays/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pays As Pays = db.Pays.Find(id)
            If IsNothing(pays) Then
                Return HttpNotFound()
            End If
            Return View(pays)
        End Function

        ' POST: /Pays/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,Nom,Abreviation,IdentifiantTelephonique,StatutExistant,DateCreation")> ByVal pays As Pays) As ActionResult
            If ModelState.IsValid Then
                db.Entry(pays).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(pays)
        End Function

        ' GET: /Pays/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pays As Pays = db.Pays.Find(id)
            If IsNothing(pays) Then
                Return HttpNotFound()
            End If
            Return View(pays)
        End Function

        ' POST: /Pays/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim pays As Pays = db.Pays.Find(id)
            db.Pays.Remove(pays)
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
