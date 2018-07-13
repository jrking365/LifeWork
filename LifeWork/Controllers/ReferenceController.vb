Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class ReferenceController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Reference/
        Function Index() As ActionResult
            Dim reference = db.Reference.Include(Function(r) r.Cv)
            Return View(reference.ToList())
        End Function

        ' GET: /Reference/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim reference As Reference = db.Reference.Find(id)
            If IsNothing(reference) Then
                Return HttpNotFound()
            End If
            Return View(reference)
        End Function

        ' GET: /Reference/Create
        Function Create() As ActionResult
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId")
            Return View()
        End Function

        ' POST: /Reference/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,CvId,Titre,Description,Adresse,Annee,StatutExistant,DateCreation")> ByVal reference As Reference) As ActionResult
            If ModelState.IsValid Then
                db.Reference.Add(reference)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", reference.CvId)
            Return View(reference)
        End Function

        ' GET: /Reference/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim reference As Reference = db.Reference.Find(id)
            If IsNothing(reference) Then
                Return HttpNotFound()
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", reference.CvId)
            Return View(reference)
        End Function

        ' POST: /Reference/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,CvId,Titre,Description,Adresse,Annee,StatutExistant,DateCreation")> ByVal reference As Reference) As ActionResult
            If ModelState.IsValid Then
                db.Entry(reference).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", reference.CvId)
            Return View(reference)
        End Function

        ' GET: /Reference/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim reference As Reference = db.Reference.Find(id)
            If IsNothing(reference) Then
                Return HttpNotFound()
            End If
            Return View(reference)
        End Function

        ' POST: /Reference/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim reference As Reference = db.Reference.Find(id)
            db.Reference.Remove(reference)
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
