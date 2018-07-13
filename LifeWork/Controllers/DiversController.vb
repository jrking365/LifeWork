Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class DiversController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Divers/
        Function Index() As ActionResult
            Dim divers = db.Divers.Include(Function(d) d.cv)
            Return View(divers.ToList())
        End Function

        ' GET: /Divers/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim divers As Divers = db.Divers.Find(id)
            If IsNothing(divers) Then
                Return HttpNotFound()
            End If
            Return View(divers)
        End Function

        ' GET: /Divers/Create
        Function Create() As ActionResult
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId")
            Return View()
        End Function

        ' POST: /Divers/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,CvId,Titre,Commentaire,StatutExistant,DateCreation")> ByVal divers As Divers) As ActionResult
            If ModelState.IsValid Then
                db.Divers.Add(divers)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", divers.CvId)
            Return View(divers)
        End Function

        ' GET: /Divers/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim divers As Divers = db.Divers.Find(id)
            If IsNothing(divers) Then
                Return HttpNotFound()
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", divers.CvId)
            Return View(divers)
        End Function

        ' POST: /Divers/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,CvId,Titre,Commentaire,StatutExistant,DateCreation")> ByVal divers As Divers) As ActionResult
            If ModelState.IsValid Then
                db.Entry(divers).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", divers.CvId)
            Return View(divers)
        End Function

        ' GET: /Divers/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim divers As Divers = db.Divers.Find(id)
            If IsNothing(divers) Then
                Return HttpNotFound()
            End If
            Return View(divers)
        End Function

        ' POST: /Divers/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim divers As Divers = db.Divers.Find(id)
            divers.StatutExistant = False
            db.Divers.Add(divers)
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
