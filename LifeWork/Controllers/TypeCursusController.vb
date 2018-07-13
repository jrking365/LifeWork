Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class TypeCursusController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /TypeCursus/
        Function Index() As ActionResult
            Return View(db.TypeCursus.ToList())
        End Function

        ' GET: /TypeCursus/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim typecursus As TypeCursus = db.TypeCursus.Find(id)
            If IsNothing(typecursus) Then
                Return HttpNotFound()
            End If
            Return View(typecursus)
        End Function

        ' GET: /TypeCursus/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /TypeCursus/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,Type,StatutExistant,DateCreation")> ByVal typecursus As TypeCursus) As ActionResult
            If ModelState.IsValid Then
                db.TypeCursus.Add(typecursus)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(typecursus)
        End Function

        ' GET: /TypeCursus/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim typecursus As TypeCursus = db.TypeCursus.Find(id)
            If IsNothing(typecursus) Then
                Return HttpNotFound()
            End If
            Return View(typecursus)
        End Function

        ' POST: /TypeCursus/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,Type,StatutExistant,DateCreation")> ByVal typecursus As TypeCursus) As ActionResult
            If ModelState.IsValid Then
                db.Entry(typecursus).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(typecursus)
        End Function

        ' GET: /TypeCursus/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim typecursus As TypeCursus = db.TypeCursus.Find(id)
            If IsNothing(typecursus) Then
                Return HttpNotFound()
            End If
            Return View(typecursus)
        End Function

        ' POST: /TypeCursus/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim typecursus As TypeCursus = db.TypeCursus.Find(id)
            db.TypeCursus.Remove(typecursus)
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
